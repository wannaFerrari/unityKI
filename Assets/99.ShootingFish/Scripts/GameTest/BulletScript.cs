using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveDir;
    private void Start()
    {
        Destroy(gameObject, 3f); // GameObject 나 자신을 3초 후에 삭제
    }
    void Update()
    {
        /*
        Vector3 currentPosition = transform.position;
        currentPosition.x += 10 * Time.deltaTime; // Time.deltaTime : 매 프레임마다 이전 프레임과의 시간 간격을 반환 
        //currentPosition.y += moveDir.y * moveSpeed * Time.deltaTime;
        transform.position = currentPosition;
        */
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //부딛힌 물체가 Enemy컴포넌트를 가지고 있을때만 파괴함
        if (other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            //print($"방울이 {other.name}과 충돌함");
            if (enemy.hp != 1)
            {
                enemy.hp--;
            }
            else
            {

                Destroy(other.gameObject); // 부딛힌 물체 삭제
            }

        }
        if (other.CompareTag("Boundary")) //내가 상호작용한 콜라이더가 부착된 오브젝트의 태그가 "Boundary라면
        {
            Destroy(gameObject); // 내 게임 오브젝트 삭제
        }
    }

    
}
