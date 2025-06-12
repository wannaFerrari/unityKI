using UnityEngine;

public class ObjectFindTest : MonoBehaviour
{
    //������ ���۵Ǳ� ���� ������ ���� �� �� �ִ� ������Ʈ�� �ν����Ϳ��� �Ҵ��Ͽ� ������ �� ����.
    public GameObject target;
    //�ٵ�, ������Ʈ�� ã��� �ؾ��ϴµ�, public�̸� �ȵǴ� ���.... �̷����� ?
    private GameObject privateTarget;
    private FindMe findTarget;
    private GameObject newTarget;
    private GameObject namedNewTarget;
    private GameObject componentAttachedTarget;

    void Start()
    {
        //print(target.name);

        //privateTarget�� ã�� ���.
        // 1. ��ü ������ �̸����� Ÿ���� ã�´�.
        privateTarget = GameObject.Find("PrivateTarget");
        print(privateTarget.transform.position);
        //���� ������Ʈ�� �������� ����(�������)�� ũ��,
        //���� �̸��� ������Ʈ�� ������ ���� ���, � ������Ʈ�� Ž������ Ȯ�� �� �� ����.
        //�̷� ������ Start�Լ������� ���������� ����.

        //2. ��ü ������ Ư�� ������Ʈ�� ������ �ִ� ��ü�� ã�´�.
        findTarget = FindAnyObjectByType<FindMe>();     //�������� ��� ���� ���� ��
        findTarget = FindFirstObjectByType<FindMe>();   //Hierarchy���� ���� ���� �ִ� ������Ʈ�� ã��

        print(findTarget.message);

        //3. �ƿ� ���ӿ�����Ʈ�� ���� �����ϰ� �ش� ��ü�� ������ �����Ѵ�.
        newTarget = new GameObject(); //Component�� ����Ƽ�� ������Ʈ���� �⺻������ new Ű���带 ���� ��ü ������ ����.
                                      //(�������� �ʴ´�)
                                      //���������� GameObject�� new�� ���� ��ü ������ ����.
                                      //�����ڿ��� transform�� �����
                                      //�ʿ��� ������Ʈ�� ���� ��ü�� ������. (Hierarchy����  Create Empty�� �ѰͰ� ����.)
        namedNewTarget = new GameObject("Named Target");
        componentAttachedTarget = new GameObject("Component Attached GameObject", typeof(FindMe), typeof(SpriteRenderer));

        //��ü�� ������ �� new GameObject() ���ٴ� Instatntiate�� ���� �� ��.

    }

}

