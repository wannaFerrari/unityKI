using System;
using UnityEngine;

[Serializable] // C# ��Ʈ����Ʈ(Attribute) : �ڵ带 �����ϴ� Ư�� ��� (Ŭ����, �ʵ�, �޼ҵ�) �� ���� ���͵����͸� ����
               // �� �ڿ� ���� Ŭ������ ����ȭ ����� �ο��Ѵٴ� �ǹ�
               //�޸𸮸� �˳��ϰ� ��⿡ �޸� ���� ����.. �� ���ȼ� ��ĥ���ֱ� ��
public class MyClass 
{
    public string name;
    public int id;
    public Sprite sprite;
}
public class ReferenceVariableTest : MonoBehaviour
{
    public MyClass myClass; // �����ڰ� ���� �ۼ��� ���������� �����ʹ� ��� Inspector���� �����ұ�?
                            // ����ȭ�� �ʿ���
    void Start()
    {
        print(myClass.name);
        print(myClass.id);
        print(myClass.sprite.name);
        print(myClass.sprite.rect);
    }

    
}
