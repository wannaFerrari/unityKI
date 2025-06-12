using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float moveSpeed; // 적들이 움직일 기본 속도
    public float turnInterval; // 적들이 방향을 바꿀 주기

    public int hp;

    private Vector2 moveDir; //적들이 움직일 방향

    private Rigidbody2D rigid;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private float lastTurnTime; //마지막으로 방향을 바꾼 시간



    // Update is called once per frame
    void Update()
    {
        if(Time.timeAsDouble > lastTurnTime + turnInterval)
        {
            //방향 바꿈
            moveDir = Random.insideUnitCircle;
            lastTurnTime = Time.time;
            rigid.linearVelocity = moveDir * moveSpeed;
        }
        CheckHP();

        //rigidbody가 붙어있으므로 Transform 자체를 제어하는것보다는 Rigidbody에 의존하는것이 좋다,
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
