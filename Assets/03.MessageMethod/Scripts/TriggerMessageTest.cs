using UnityEngine;

public class TriggerMessageTest : MonoBehaviour
{
    //Collider 컴포넌트의 IsTrigger 속성을 true로 설정해 놓으면
    //물리적인 충돌을 일으키지 않는 대신 Collider 영역 내에 다른
    //Collider가 진입했을 때 상호작용 가능.
    //OnCollisionXX 메시지 함수와 마찬가지로 두 오브젝트중 하나는 반드시 Rigidbody가 있어야 한다.
    //OnTriggerXX 메세지 함수는 충돌정보 각체를 생성하지 않으므로 비교적 효율적이다.

    void OnTriggerEnter(Collider other)
    {
        print($"트리거에 진입함. 나 : {name}, 대상 : {other.name}");
    }

    void OnTriggerExit(Collider other)
    {
        print($"트리거에서 나감. 나 : {name}, 대상 : {other.name}");
    }

    void OnTriggerStay(Collider other)
    {
        print($"트리거에 체류중. 나 : {name}, 대상 : {other.name}");
    }
}
