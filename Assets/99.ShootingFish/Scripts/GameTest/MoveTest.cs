using UnityEditor.Timeline;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    //public Transform myTransform;

    public float moveSpeed = 10f;
    public Vector3 moveDir;
    public SpriteRenderer spriteRenderer;
    public GameObject gameObject;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        moveDir = new Vector3(x, y);
        if (x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (x > 0) 
        {
            spriteRenderer.flipX= false;
        }
        if (Input.GetButtonDown("Jump")||Input.GetMouseButtonDown(0))
        {
            print("�����̽��� ����");
            
            //�����̴� �������� ������ ���� �Ÿ���ŭ �����̵� �ϵ���
            
            //Teleport(moveDir);
            
            //GameObject g = Instantiate(gameObject, transform.position, Quaternion.identity);
            //g.AddComponent<Rigidbody>();
            //g.GetComponent<Rigidbody>().AddForce(transform.right * 1000);


            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //���콺�� ��ũ������ ��� ��ġ�� �ִ��� ���� ��ǥ�� ��ȯ�ϴ� �Լ�

            //��ġ1���� ��ġ2�� ���ϴ� ���⺤�͸� ���ϴ� ���� : ��ġ2 - ��ġ1
            //���� ���͸� Ȱ���Ҷ�, ���� ũ�Ⱑ �ʿ� ���ٸ� ���� ���̸� 1�� ����.

            Vector3 fireDir = mousePos - transform.position;
            fireDir.z = 0;
            fireDir = fireDir.normalized; //������ ���̸� 1�� �������ִ� �Լ�
            Fire(fireDir);
        }
        Move(moveDir);
    }

    void Move(Vector3 moveDir)
    {
        //print("Update ȣ���");
        // �� ���ӿ�����Ʈ�� �����Ǿ� �ִ� transform component�� �ٷ� ������ �� ����.
        //transform.position = new Vector3(1,0,0); // �� ��ü�� position�� ��Ȯ�� ������ǥ 1,0,0 ���� �̵���Ŵ
        //transform.position.x++; //Transform.position�� ������Ÿ�̱� ������ ���� �ʵ��� x ���� �ٷ� ������ �� ����.


        /*
        Vector3 currentPosition = transform.position;
        currentPosition.x += moveDir.x * moveSpeed * Time.deltaTime; // Time.deltaTime : �� �����Ӹ��� ���� �����Ӱ��� �ð� ������ ��ȯ 
        currentPosition.y += moveDir.y * moveSpeed * Time.deltaTime;
        transform.position = currentPosition;
        */
        //transform.Translate(moveDir * moveSpeed * Time.deltaTime); //Translate �޼��� : �̵��� ���� ���͸� �Ķ���ͷ� �Է��ϸ� ���� ��ġ���� �ش� ��ġ�� �̵�
        this.GetComponent<Rigidbody2D>().AddForce(moveDir * moveSpeed );
    }

    void Teleport(Vector3 moveDir)
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x += moveDir.x*1; // Time.deltaTime : �� �����Ӹ��� ���� �����Ӱ��� �ð� ������ ��ȯ 
        currentPosition.y += moveDir.y*1;
        transform.position = currentPosition;

    }

    void Fire(Vector3 fireDir)
    {
        BulletScript bullet = Instantiate(gameObject, transform.position, Quaternion.identity).GetComponent<BulletScript>();
        //�����Ǵ� �Ѿ��� fireDir�������� �߻��ϰ� ����
        bullet.moveDir = fireDir;   
    }
}
