using UnityEngine;

public class UpdateMessageTest : MonoBehaviour
{
    //����Ƽ�� Update �迭 �޽��� �Լ��� �� ������ �Ǵ� ������ �ʿ��� ���� �ֱ⸶�� ȣ��ȴٴ� �������� ������,
    //�뵵�� ���� ȣ��Ǵ� ������ ���� ���̰� �ִ�.

    //1. Update : �� �������� �߰��� ȣ��
    float preFrameTime = 0; //���� �������� ȣ�� �ð�
    void Update()
    {
        print($"Updateȣ���. ȣ��ð� : {Time.time}, ���� �����Ӱ� �ð� ���� : {Time.time - preFrameTime}");
        preFrameTime = Time.time;
        print($"deltaTime : {Time.deltaTime}");
        
    }



    //2. FixedUpdate : �����Ӱ��� ������ ���� ������ ����� ������ ȣ��. ȣ�� �ֱⰡ �����Ǿ� ����.
    //���� ���°�? : Transform�� ���������� �Բ� �����ϱ� ���� ���� ����.
    //������ �� : Update�� ȣ�� ������ �ٸ��Ƿ�, �Է��̳� ������ ���� �����ϱ⿡�� ������.
    float preFixedUpdateTime = 0;
    void FixedUpdate()
    {
        print($"FixedUpdateȣ���. ȣ��ð� : {Time.time}, ���� FixedUpdate���� �ð� ���� : {Time.time - preFixedUpdateTime}");
        preFixedUpdateTime = Time.time;
        print($"FixedDeltaTime : {Time.fixedDeltaTime}");

        //�� �Է��� ���� �� �� ����
        if (Input.GetButtonDown("Jump"))
        {
            print("����");
        }
    }

    //3. LateUpdate : �� �����Ӹ��� ��� ���μ���(������, �浹ó�� ��)�� ���� ��, �� �������� ȣ��.
    //���� �����ӿ��� ȣ�� �ǹǷ� Update�ʹ� ȣ�� ������ �ٸ��� �ð����̴� ũ�� ����.
    //�������°�? : �ٸ� ��� ��ü���� �������� ���� �� ȣ��ǹǷ�, ī�޶� ������ ���� �����ϱ� ����.
    void LateUpdate()
    {
        print($"LateUpdate ȣ���. ȣ�� �ð� : {Time.time} update ȣ�� �������� �ð� ���� : {Time.time - preFrameTime}");
    }

    //update ���� �޽��� �Լ��� �������� ������ : 
    //�޽����Լ��� �ƿ� ���ǵǾ� ���� ������, ȣ�� ��ü�� ���ϸ�
    //���� �޽��� �Լ��� ���Ǵ� �Ǿ� �ִµ� ������ ���� ���
    //��, �� Update�� �ǹ̾��� �޼ҵ带 �����ϴ��� �ϴ� ȣ���� �ϹǷ� �����κ� ������尡 �߻��Ѵ�.
}
