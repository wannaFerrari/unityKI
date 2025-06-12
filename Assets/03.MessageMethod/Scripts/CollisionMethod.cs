using UnityEngine;

public class CollisionMethod : MonoBehaviour
{
    //물리적인 충돌 발생 시 호출되는 메시지 함수가 있음
    //OnCollision 시리즈
    //이 메시지 함수들은 호출 주체가 Physics와 관련이 있으므로, 반드시 충돌한 오브젝트중 하나에는 꼭 RigidBody가 붙어있어야 함

    //1. OnCollisionEnter : 충돌이 일어났을때 호출
    void OnCollisionEnter(Collision c)//충돌상태의 정보가 담긴 객체(Collision클래스)
    {
        Collider other = c.collider; // 충돌을 일으킨 대상
        print($"충돌 발생!  나:{name}, 부딛힌 애 : {other.name}");
    }

    //2. OnCollisionExit : 충돌되던 콜라이더가 다시 충돌이 아니게 되면 호출.
    void OnCollisionExit(Collision collision)
    {
        Collider other = collision.collider; //충돌을 일으킨 대상
        print($"충돌 끝!  나:{name}, 부딛힌 애 : {other.name}");
    }

    //3. OnCollisionStay : 충돌중일 때, 플레임마다 호출.
    void OnCollisionStay(Collision collision)
    {
        Collider other = collision.collider; //충돌을 일으킨 대상
        print($"충돌중~~     나:{name}, 부딛힌 애 : {other.name}");
    }
}
