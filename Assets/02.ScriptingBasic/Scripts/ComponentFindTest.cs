using UnityEngine;

public class ComponentFindTest : MonoBehaviour
{
    //���� ������Ʈ�� �˰� �ִ� ���¿���, �� ������Ʈ�� ������ Ư�� ������Ʈ�� ã���� �� ���.
    public GameObject target;
    public Sprite someSprite;
    void Start()
    {
        //target ������Ʈ���� FindMe ������Ʈ�� ����������
        FindMe findMe = target.GetComponent<FindMe>();
        print(findMe.message);
        bool isFinded = target.TryGetComponent<SpriteRenderer>(out SpriteRenderer spRenderer);

        if (isFinded)
        {
            //������Ʈ�� ã�µ� ����
            spRenderer.sprite = someSprite;
        }
        else
        {
            //������Ʈ�� ��ã��.
            print("ã�� ������Ʈ�� �����ϴ�.");
        }
        isFinded = target.TryGetComponent<Collider2D>(out Collider2D coll);
        if (isFinded)
        {
            //������Ʈ�� ã�µ� ����
            print(coll.offset);
        }
        else
        {
            //������Ʈ�� ��ã��.
            print("ã�� ������Ʈ�� �����ϴ�.");
        }

        //Hierarchy�� �ڽ� ������Ʈ�鿡 �پ��ִ� ������Ʈ�鵵 ã�� �� �ִ�.
        FindMe[] children = target.GetComponentsInChildren<FindMe>(true);
        //�ڱ� �ڽſ� ������ ������Ʈ�� �����Ѵ�.
        //�����ε� �� �޼ҵ� ��, includeInactive�� true�� �����ϸ� ��Ȱ��ȭ �� �ڽĵ� ����.

        foreach (FindMe child in children)
        {
            print(child.message);
        }

        FindMe newFindme = target.AddComponent<FindMe>();
        newFindme.message = "���Ӱ� ���� ã���ּ̱���";
    }
}
