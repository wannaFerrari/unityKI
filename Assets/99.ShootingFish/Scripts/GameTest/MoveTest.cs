using UnityEditor.Timeline;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    //public Transform myTransform;

    public float moveSpeed = 10f;
    public float bulletSpeed;
    public float fireInterval = 0.1f; // 발사 간격
    private float lastFireTime = 0; // 직전 발사 시간
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

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //마우스가 스크린에서 어느 위치에 있는지 월드 좌표를 반환하는 함수

        //위치1에서 위치2로 향하는 방향벡터를 구하는 공식 : 위치2 - 위치1
        //방향 벡터를 활용할때, 힘의 크기가 필요 없다면 벡터 길이를 1로 고정.

        Vector3 fireDir = mousePos - transform.position;
        fireDir.z = 0;

        gunPivot.right = fireDir;//총을 자식으로 가지고 있는 GunPivot의 Transform을 회전

        gunRenderer.flipY = fireDir.x < 0; //총을 발사할 방향이 왼쪽 (방향 벡터의 x값이 -)일 경우 총의 위아래를 바꿔줌
        //if(fireDir.x)

        if (Input.GetButtonDown("Jump")||Input.GetMouseButton(0))
        {
            print("스페이스바 눌림");
            
            //움직이는 방향으로 앞으로 일정 거리만큼 순간이동 하도록
            
            //Teleport(moveDir);
            
            //GameObject g = Instantiate(gameObject, transform.position, Quaternion.identity);
            //g.AddComponent<Rigidbody>();
            //g.GetComponent<Rigidbody>().AddForce(transform.right * 1000);


            
           
            fireDir = fireDir.normalized; //벡터의 길이를 1로 고정해주는 함수
            Fire(fireDir);
        }
        Move(moveDir);
    }

    void Move(Vector3 moveDir)
    {
        //print("Update 호출됨");
        // 내 게임오브젝트에 부착되어 있는 transform component를 바로 참조할 수 있음.
        //transform.position = new Vector3(1,0,0); // 내 객체의 position을 정확히 월드좌표 1,0,0 으로 이동시킴
        //transform.position.x++; //Transform.position이 프로퍼타이기 때문에 내부 필드인 x 값을 바로 수정할 수 없음.


        /*
        Vector3 currentPosition = transform.position;
        currentPosition.x += moveDir.x * moveSpeed * Time.deltaTime; // Time.deltaTime : 매 프레임마다 이전 프레임과의 시간 간격을 반환 
        currentPosition.y += moveDir.y * moveSpeed * Time.deltaTime;
        transform.position = currentPosition;
        */
        //transform.Translate(moveDir * moveSpeed * Time.deltaTime); //Translate 메서드 : 이동할 방향 벡터를 파라미터로 입력하면 현재 위치에서 해당 위치로 이동
        this.GetComponent<Rigidbody2D>().AddForce(moveDir * moveSpeed );
    }

    void Teleport(Vector3 moveDir)
    {
        Vector3 currentPosition = transform.position;
        currentPosition.x += moveDir.x*1; // Time.deltaTime : 매 프레임마다 이전 프레임과의 시간 간격을 반환 
        currentPosition.y += moveDir.y*1;
        transform.position = currentPosition;

    }

    

    void Fire(Vector3 fireDir)
    {
        if (Time.time < lastFireTime + fireInterval) return; //아직 다음 발사시간이 안되었으면 return
        lastFireTime = Time.time;

        foreach (Transform shotPoint in shotPoints)
        {
            BulletScript bullet = Instantiate(gameObject, shotPoint.position, shotPoint.rotation).GetComponent<BulletScript>();
            //생성되는 총알을 fireDir방향으로 발사하고 싶음
            //bullet.transform.right = shotPoint.right;
            bullet.moveSpeed = bulletSpeed;
        }
    }
}
