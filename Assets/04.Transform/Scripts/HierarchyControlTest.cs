using System.Net.Sockets;
using UnityEngine;

public class HierarchyControlTest : MonoBehaviour
{
    //����Ƽ���� Transform�� ����󿡼��� ��ġ��� �ϱ⵵ ������
    //�� ������Ʈ�� �ڽ����� ������ �ִ� �θ� ������Ʈ�κ����� ��� ��ǥ �Ǵ� ���� ���� �����Ѵ�.
    //�̷� Ư¡��� ����Ƽ�� Transform�� Hierarchy���� �θ��ڽİ��赵 �����Ѵ�.

    public GameObject otherObject;

    void Start()
    {
        print($"�� : {transform.name}");
        //trasnform.GetChild(index) : �� �ڽ��� Ư�� �ε����� �ִ� �ڽ��� ������
        Transform child = transform.GetChild(0);
        print($"�� �ڽ� : {child.name}");

        Transform grandChild = child.GetChild(0);
        print($"�� �ڽ��� �ڽ� : {grandChild.name}");


        Transform secondChild = transform.GetChild(1);
        print($"�� �ι�° �ڽ� : {secondChild.name}");

        //transform.Find("name") : �� �ڽ��� Ư�� �̸��� ���� �ڽ��� ������
        Transform findMe = transform.Find("FindMe");
        print($"ã�� �ڽ� : {findMe.name}, �� �ڽ��� ���� : {findMe.GetSiblingIndex()}");

        //�� �θ� �ٸ� Transform���� �ٲ�.
        //transform.parent = otherObject.transform;
        //transform.SetParent : �⺻������ ���� property�� ���� �θ� �� ���ӿ�����Ʈ�� transform�� �����ϴ� �Ͱ� ������,
        //transform.SetParent(otherObject.transform, false); //��ġ�� ������ �ϴ� ����� �����ε带 ���� �����ȴ�.

        //child�� otherObject�� �ڽ����� ����.
        //child.SetParent(otherObject.transform, false);
        
        //Hierarchy�� �ڽ� ������ ���� ����
        secondChild.SetAsFirstSibling();
        findMe.SetAsLastSibling();
        child.SetSiblingIndex(4);

        Transform square = transform.Find("Square");
        print($"square�� world Position : {square.position}");
        print($"Square�� �θ�κ����� ��� ��ġ (local position : {square.localPosition}");

        Vector3 relativePos; //square ���忡�� otherObject�� ��ġ
        relativePos = square.TransformPoint(otherObject.transform.position);
        print($"Sqaure�� ���� otherObject�� ����� ��ġ : {relativePos}");

    }
}
