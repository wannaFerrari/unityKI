using UnityEngine;

public class CreateAndDestroyTest : MonoBehaviour
{
    public GameObject original;
    public FindMe originalComponent;


    //���� �͵�
    private GameObject clone;
    private GameObject childClone;
    private GameObject movedClone;
    private FindMe clonedComponent;
    void Start()
    {
        //original�̶� �Ȱ��� ���� ��ü�� �ϳ� �����ϰ� �ʹ�.
        //GameObject clone = new GameObject("Clone Cube");
        //MeshFilter mf = clone.AddComponent<MeshFilter>();
        //MeshRenderer mr = clone.AddComponent<MeshRenderer>();
        //BoxCollider coll = clone.AddComponent<BoxCollider>();

        //mf.mesh = original.GetComponent<MeshFilter>().mesh;
        //mr.material = original.GetComponent<MeshRenderer>().material;
        //coll.size = original.GetComponent<BoxCollider>().size;
        //coll.center = original.GetComponent<BoxCollider>().center;
        //===================��ó�� ������ ������ ���ľ� ���簡 �Ǵ� ������.....

        //�׳� Instantiate�� ���� ���̴�!
        clone = Instantiate(original); // �׳� ����
        clone.name = "clone";


        // transform�� �Ķ���ͷ� ������ ���, �ش� �Ķ������ "�ڽ�"���� ����
        childClone = Instantiate(original, transform);
        childClone.name = "childClone";
        //Vector3�� Quaternion�� �Ķ���ͷ� ������ ���, �ش� ��ġ�� ������ ���� ���·� ����
        movedClone = Instantiate(original, new Vector3(3,2,1), Quaternion.Euler(45,30,90));
        movedClone.name = "movedClone";
        //���� orinigal�� Component�� ���, �ش� ������Ʈ�� �پ��ִ� gameObject�� ���� ���·� ���� ������Ʈ�� �����ϰ�,
        //original�� ���� ������Ʈ�� ��ȯ.

       clonedComponent = Instantiate<FindMe>(originalComponent);
        clonedComponent.message = "�̰��� Ŭ���Դϴ�.";
        clonedComponent.name = "clonedComponent";
        Invoke("DestroyClones", 3f); // 3�� �Ŀ�"DestroyClones��� �̸��� �޼ҵ带 ȣ������(�Ķ���Ͱ� �������.)
    }

    private void DestroyClones()
    {
        //Ŭ�� 4���� �ı�����
        //���� ������Ʈ�� ���� ���.
        Destroy(clone); // clone�̶�� ������Ʈ�� �ı��� ���ε�, 
        print($"{clone.name}�� �ı���"); //NullReferenceException�� �����ҰͰ����� �ȶ���???

        // Destroy�޼ҵ�� �Ķ���͸� �����ž��� ��ü�� ����� �Ѵ�.
        // �ش� �������� ������ �����ȴ�.

        Destroy(childClone, 3f); //3�� �Ŀ� childClone ����, ���������� �ش� �������� ���� �������� �ϰ� ����

        Destroy(clonedComponent); //���� �Ķ���Ͱ� GameObject�� �ƴϸ�, �ش� ������Ʈ�� �� ����.
        //���� ���, clonedComponent�� Cube(Clone)�� ������ FindMe ������Ʈ �̹Ƿ�, �ش� ������Ʈ�� ����.

        //�̹� �������� �ƴ϶�, ���� ��� ��ü�� �ı��Ǿ�� �� ��찡 ���� ����.
        //���� ��� ����Ƽ���� �̱��������� �����Ѵٴ���... 

        DestroyImmediate(movedClone); // ��� ��ü�� �����Ǿ� null�� ��

        if(movedClone == null){
            print("movedClone�� ���� ����");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
