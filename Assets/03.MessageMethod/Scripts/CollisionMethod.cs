using UnityEngine;

public class CollisionMethod : MonoBehaviour
{
    //�������� �浹 �߻� �� ȣ��Ǵ� �޽��� �Լ��� ����
    //OnCollision �ø���
    //�� �޽��� �Լ����� ȣ�� ��ü�� Physics�� ������ �����Ƿ�, �ݵ�� �浹�� ������Ʈ�� �ϳ����� �� RigidBody�� �پ��־�� ��

    //1. OnCollisionEnter : �浹�� �Ͼ���� ȣ��
    void OnCollisionEnter(Collision c)//�浹������ ������ ��� ��ü(CollisionŬ����)
    {
        Collider other = c.collider; // �浹�� ����Ų ���
        print($"�浹 �߻�!  ��:{name}, �ε��� �� : {other.name}");
    }

    //2. OnCollisionExit : �浹�Ǵ� �ݶ��̴��� �ٽ� �浹�� �ƴϰ� �Ǹ� ȣ��.
    void OnCollisionExit(Collision collision)
    {
        Collider other = collision.collider; //�浹�� ����Ų ���
        print($"�浹 ��!  ��:{name}, �ε��� �� : {other.name}");
    }

    //3. OnCollisionStay : �浹���� ��, �÷��Ӹ��� ȣ��.
    void OnCollisionStay(Collision collision)
    {
        Collider other = collision.collider; //�浹�� ����Ų ���
        print($"�浹��~~     ��:{name}, �ε��� �� : {other.name}");
    }
}
