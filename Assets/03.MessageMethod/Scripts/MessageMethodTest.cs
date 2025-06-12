using UnityEngine;

public class MessageMethodTest : MonoBehaviour
{
    //����Ƽ �޽��� �Լ�
    //�����ڰ� ȣ�� �� ���� ������, ���� ȣ������ �ʾƵ� ����Ƽ ���� ���μ����� �߻��ϴ� �̺�Ʈ�� ����
    //    ����Ƽ ������ ȣ�����ִ� �Լ�
    //���������ڰ� ������ �Ǵ� ��� ����(private�̾ ȣ��ǰ�, public�̸� �ٸ�Ŭ�������� ���� ȣ�⵵ ����)

    //1. Awake : ��ü�� �ε�(� ��� �ε� ����)���ڸ��� ȣ��.
    //Scene �ε�ÿ� Awake �Լ����� �ٸ� ��ü�� ������ ���, ���� �ٸ� ��ü�� �ε���� ���� ������ �� �־�
    // �ǵ���� �۵����� ���� ���ɼ��� ����. 
    // �׷��Ƿ�, Awake������ �� ��ü�� ���� �ٸ� ������Ʈ�� ���� �ʱ�ȭ�� �����ϴ� �뵵�� ����Ѵ�.

    public Sprite sprite;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        //�� ���� ������Ʈ�� ���� SpriteRenderer�� ������.
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;
        print($"Awakeȣ��, ȣ�� �ð� : {Time.time}");
    }


    //2. Start : Update�� ȣ��Ǳ� ���� �ѹ� ȣ��
    void Start()
    {
        print($"Startȣ��, ȣ�� �ð� : {Time.time}");

    }

    //3. Update : ������ ���۵� ��, �� �����Ӹ��� �ѹ��� ȣ��
    int frameCount = 0;
    void Update()
    {
       // print($"Updateȣ��, ȣ�� �ð� : {frameCount++}");

    }

    //4. OnEnable/OnDisable : �� ������Ʈ�� ���ӿ�����Ʈ�� Ȱ��ȭ/��Ȱ��ȭ �� �� ȣ��.
    //���� : OnEnable�� ���ӿ�����Ʈ �ε尡 �Ϸ�� �Ŀ� ȣ�� �ǹǷ�, ù 1ȸ�� Start���� ���� ȣ��.
    void OnEnable()
    {
        print("OnEnable ȣ��");
    }

    void OnDisable()
    {
        print("OnDisable ȣ��");
    }

    //5. OnDestroy : ���� ������Ʈ �Ǵ� ������Ʈ�� �����ɶ� ȣ��.
    //���� : ���� ��Ȱ��ȭ ���� �ʴ���, Ȱ��ȭ �Ǿ��ִ� ������Ʈ�� �����ɶ��� OnDisable()�� ���� �ѹ� ȣ���.

    void OnDestroy()
    {
        print($"{name}�� OnDestroyȣ��");
    }
}
