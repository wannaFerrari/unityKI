using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float moveSpeed; // ������ ������ �⺻ �ӵ�
    public float turnInterval; // ������ ������ �ٲ� �ֱ�

    public int hp;

    private Vector2 moveDir; //������ ������ ����

    private Rigidbody2D rigid;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private float lastTurnTime; //���������� ������ �ٲ� �ð�



    // Update is called once per frame
    void Update()
    {
        if(Time.timeAsDouble > lastTurnTime + turnInterval)
        {
            //���� �ٲ�
            moveDir = Random.insideUnitCircle;
            lastTurnTime = Time.time;
            rigid.linearVelocity = moveDir * moveSpeed;
        }
        CheckHP();

        //rigidbody�� �پ������Ƿ� Transform ��ü�� �����ϴ°ͺ��ٴ� Rigidbody�� �����ϴ°��� ����,
        transform.Translate(moveDir* moveSpeed * Time.deltaTime);
        
    }
    private void CheckHP()
    {
        if (hp == 3)
        {
            spriteRenderer.color = Color.green;
        }
        else if (hp == 2)
        {
            spriteRenderer.color = Color.yellow;
        }
        else if (hp == 1)
        {
            spriteRenderer.color = Color.red;
        }
    }
}
