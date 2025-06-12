using UnityEngine;

public class TriggerMessageTest : MonoBehaviour
{
    //Collider ������Ʈ�� IsTrigger �Ӽ��� true�� ������ ������
    //�������� �浹�� ����Ű�� �ʴ� ��� Collider ���� ���� �ٸ�
    //Collider�� �������� �� ��ȣ�ۿ� ����.
    //OnCollisionXX �޽��� �Լ��� ���������� �� ������Ʈ�� �ϳ��� �ݵ�� Rigidbody�� �־�� �Ѵ�.
    //OnTriggerXX �޼��� �Լ��� �浹���� ��ü�� �������� �����Ƿ� ���� ȿ�����̴�.

    void OnTriggerEnter(Collider other)
    {
        print($"Ʈ���ſ� ������. �� : {name}, ��� : {other.name}");
    }

    void OnTriggerExit(Collider other)
    {
        print($"Ʈ���ſ��� ����. �� : {name}, ��� : {other.name}");
    }

    void OnTriggerStay(Collider other)
    {
        print($"Ʈ���ſ� ü����. �� : {name}, ��� : {other.name}");
    }
}
