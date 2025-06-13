using UnityEditor.Timeline;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    //public Transform myTransform;

    public float moveSpeed = 10f;
    public float bulletSpeed;
    public float fireInterval = 0.1f; // �߻� ����
    private float lastFireTime = 0; // ���� �߻� �ð�
    public float rotateSpeed;
    public Vector3 moveDir;
    public SpriteRenderer spriteRenderer;
    public GameObject gameObject;

    public Transform gunPivot;
    public Transform[] shotPoints;

    public SpriteRenderer characterRenderer;
    public SpriteRenderer gunRenderer;
    
    void Awake()
    {
        gunPivot = transform.Find("GunPivot");
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        moveDir = new Vector3(x, y);
        if (x < 0)
        {
            //characterRenderer.flipX = true;
            transform.Rotate(0, rotateSpeed * Time.deltaTime,0);
        }
        else if (x > 0) 
        {
            //characterRenderer.flipX= false;
            transform.Rotate(0,  rotateSpeed * Time.deltaTime,0);
        }
        else if(x ==0 && y == 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //���콺�� ��ũ������ ��� ��ġ�� �ִ��� ���� ��ǥ�� ��ȯ�ϴ� �Լ�

        //��ġ1���� ��ġ2�� ���ϴ� ���⺤�͸� ���ϴ� ���� : ��ġ2 - ��ġ1
        //���� ���͸� Ȱ���Ҷ�, ���� ũ�Ⱑ �ʿ� ���ٸ� ���� ���̸� 1�� ����.

        Vector3 fireDir = mousePos - transform.position;
        fireDir.z = 0;

        gunPivot.right = fireDir;//���� �ڽ����� ������ �ִ� GunPivot�� Transform�� ȸ��

        gunRenderer.flipY = fireDir.x < 0; //���� �߻��� ������ ���� (���� ������ x���� -)�� ��� ���� ���Ʒ��� �ٲ���
        //if(fireDir.x)

        if (Input.GetButtonDown("Jump")||Input.GetMouseButton(0))
        {
            print("�����̽��� ����");
            
            //�����̴� �������� ������ ���� �Ÿ���ŭ �����̵� �ϵ���
            
            //Teleport(moveDir);
            
            //GameObject g = Instantiate(gameObject, transform.position, Quaternion.identity);
            //g.AddComponent<Rigidbody>();
            //g.GetComponent<Rigidbody>().AddForce(transform.right * 1000);


            
           
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
        if (Time.time < lastFireTime + fireInterval) return; //���� ���� �߻�ð��� �ȵǾ����� return
        lastFireTime = Time.time;

        foreach (Transform shotPoint in shotPoints)
        {
            BulletScript bullet = Instantiate(gameObject, shotPoint.position, shotPoint.rotation).GetComponent<BulletScript>();
            //�����Ǵ� �Ѿ��� fireDir�������� �߻��ϰ� ����
            //bullet.transform.right = shotPoint.right;
            bullet.moveSpeed = bulletSpeed;
        }
    }
}
