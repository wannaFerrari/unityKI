using UnityEngine;

public class UnityAttributeTest : MonoBehaviour
{
    //����Ƽ������ Inspector���� ���� ���Ǹ� ���� �پ��� ��Ʈ����Ʈ�� �����Ѵ�.

    public int publicIntVar;

    //1. SerializeField : �Ϲ������� �ν����Ϳ��� �������� �ϴ� private �Ǵ� protect�ʵ带
    //Inspector���� ���� �����ϵ��� �ϴ� ���
    [SerializeField]
    private int privateIntVar;

    //2. TextArea : Inspector���� ���ڿ� �Է¶��� ������ �ƴ϶� �����ٷ� �Է� �����ϵ��� ǥ����.
    [TextArea(2,10)]
    public string text;

    //������ʹ� �ɼǻ����̶�� ��ȹ�ڳ� ����Ƽ ������ �۾��ڿ��� �˷��ְ� �ʹ�.
    //3. Header : Inspector �߰��� Ư�� ������ ��ó�� ��������
    [Header("������ʹ� �ɼ�")]
    public int otherIntVar;

    //4. Space : ����?
    [Space(30)]
    public float floatVar;

    //5. Range : int �Ǵ� float ������ �ִ�/�ּҰ��� �����ϰ�, �����̴��ٷ� ���� ������ �� �ֵ��� ����.
    [Range(-5,5)]
    public int rangedInt;

    [Range(0,1)]
    public float rangedFloat;

    //6. Tooltip : Inspector���� �ش� ������ ���콽�� �ø��� ������ ǥ��
    [Tooltip("�̰��� �����Դϴ�.")]
    public string otherText;

    //7. HideInInspector : SerializeField�� �ݴ��, public ������ �ν����Ϳ��� ����
    [HideInInspector]  // ����׸�忡���� �Ⱥ���
    public int notSupportedintVar;

    //�ν����Ϳ����� ������, ��ũ��Ʈ������ ������ �����ϵ��� �ϱ����ؼ��� internal ���������ڰ� ���� ����.
    internal int internalIntVar;

    //�Ǵ� public property�� �ۼ��ϴ°��� ���� ������.
    public int IntProperty {  get; set; }
}
