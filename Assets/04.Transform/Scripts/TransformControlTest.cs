using UnityEngine;

public class TransformControlTest : MonoBehaviour
{
    //Transform : ����Ƽ�� ��� ���� ������Ʈ�� �Ѱ��� ������ �ִ� ������Ʈ
    //�⺻������ ���� �� �󿡼� ��ġ, ����(����), ũ�� ���� ������ �� �ִ�.
    //Hierarchy�󿡼��� �θ�/�ڽ� ���赵 Transform�� ���� ����ȴ�.
    //�ڽĿ�����Ʈ�� �⺻������ �θ� ������Ʈ�� �������� ���󰡵��� �Ǿ��ֱ⶧��.

    void Start()
    {
        // ControlStarightly();
        ControlByMethod();

        //transform.position = new Vector3(5,0,0);
        //transform.Translate(new Vector3(5, 0, 0));
    }

    void Update()
    {
        //ControlByDirection();
        //transform.Translate(5*Time.deltaTime, 0, 0);
        //transform.Rotate(30*Time.deltaTime,0,0);   
        ControlByMethod();
    }

    //Transform�� ��ġ ���� ���
    //1. ���� ���� �����Ͽ� ��ġ�� �̵�
    void ControlStarightly()
    {
        //transform.position : ������Ƽ�̱� ������, get �������� ���� �Է¹޴°� �ƴ϶�, ���� ���ӻ󿡼� ��ġ�� �̵��Ѵ�.
        transform.position = new Vector3(3,2,1); //x:3, y:2, z:1

        //transform.rotation : ������ ������ �����ϱ� ���� ����� �ڷ����� Quaternion�� �����
        //transform.rotation = new Quaternion(0.3f, 0.02f, 0.001f, 0);
        //����� ������ ��Ȯ�� �����Ͽ� ���� �����ϱ� ��ƴ�.(���������� �ʴ�.)
        //���������� ����ϱ� ���ؼ��� x,y,z ���� ����(0~360)�� �����ϴ°� ����.
        //�����ڰ� rotation�� ���� ���������� �����ϱ� ���ؼ� ���Ϸ����� Ȱ��.
        transform.rotation = Quaternion.Euler(45,30,90);
        transform.localScale = new Vector3(4, 5, 6);

    }
    public Transform lookTarget;
    //2. rotation�� ������ ��, ������ �̿��ϴ� ��
    void ControlByDirection()
    {
        //�ٶ� ���� ���ϱ� : �� trasnform�� lookTarget�� �ٶ���� ��.
        Vector3 lookDir = lookTarget.position - transform.position;
        //���� ���ͷ� Ȱ�� �Ҷ��� ũ�Ⱑ ����� ����.

        //transform.right; // x ������ +�� �Ǵ� ����
        //transform.up;   //y ������ +�� �Ǵ� ����
        //transform.forward // z ������ +�� �Ǵ� ����

        transform.right = lookDir;
        //transform.up = lookDir;
        
    }

    //3. �޼ҵ带 ���ؼ� position�� rotation�� ������ �� �ִ�.
    void ControlByMethod()
    {
        //Transform�� ���� �� �������� Ư�� ���� �ջ��ϴ� ������� ��ġ�� ������ �����ϴ� �޼ҵ带 ����
        //Transform.Translate : ȣ��� ������ ���� ��ġ�� �Ķ���͸�ŭ �ջ��� ��ġ�� Transform�� �̵�
        //transform.Translate(5,0,0);
        //transform.position = new Vector3(5,0,0); �� ������ �ƴ϶�,
        //transform.position += new Vector3(5,0,0); �� ����

        //Transform.Rotate : ȣ��� ������ ���� �������� �Ķ���͸�ŭ �ջ��� ������ Transform�� ȸ��
        // transform.Rotate(30,0,0);

        //axis�� �Ķ���ͷ� �޴� �����ε�� Rotate�� ���⺤�ͷ� axis�� �޾� ������ ���.
        //���⺤���̱� ������ axis�� ũ��� ��� ����. ���⸸ ������ ��.
        //transform.Rotate(axis : new Vector3(1, 1, 1), angle : 30 * Time.deltaTime);

        //transform.LookAt : �⺻������ transform.forward = ���⺤�� �����ϴ°Ͱ� ���� ����.
        //�������� transrofm�� ���⵵ ������� worldUp�� ���ϵ��� ����
        //worldUp�� ������ ���, Vector3.up�� wroldup�� ��
        //transform.forward = lookTarget.position - transform.position;
        transform.LookAt(lookTarget,Vector3.left);
    }
}
