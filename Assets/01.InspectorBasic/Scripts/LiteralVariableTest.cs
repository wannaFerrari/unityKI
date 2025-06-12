using UnityEngine;

public class LiteralVariableTest : MonoBehaviour
{

    const uint MonsterHP = 100;

    //����
    public byte byteVar = byte.MaxValue;
    public sbyte sbyteVar;
    public short shortVar;
    public ushort ushortVar;
    public int intVar = 1;
    public uint uintVar = MonsterHP;
    public long longVar;
    public ulong ulongVar;

    //�Ǽ�
    public float floatVar = 1.1f;
    public double doubleVar = 1.4;
    public decimal decimalVar; //decimal ������Ÿ���� ����Ƽ�� Inspector â���� ������ �Է��� �������� ����

    //�� ��
    public bool boolVar;
    public char charVar;
    public string stringVar;

    void Start()
    {
        Debug.Log(intVar);
    }

    private void Reset()
    {
        Debug.Log("Reset ȣ��");
        floatVar = 1.3f;
    }

}
