using UnityEngine;

public class UnityStructTest : MonoBehaviour
{
    //����Ƽ ���� ����ü : ����Ƽ���� ������ ���� �������� ����ϰ� ���̴� �����͸� ����ü�� ������.

    //1. Vector �ø��� : 2D, 3D, 4D ���� �󿡼��� ��ǥ �Ǵ� ���� ũ�⸦ ��Ÿ���� ���� ����ü

    public Vector2 vector2;
    public Vector3 vector3;
    public Vector4 vector4;

    //2. Quarternion : 4����. 3������ �ప�� 1���� ����θ� ����Ͽ� 3���� �������� ���� ���� ���� ��ġ��
    //"������"  ������ �����ϱ� ���� ����. Transform.Rotation�� �⺻ �ڷ����̴�.
    public Quaternion quaternion;

    //3. VectorInt �ø��� : ��ǥ���� ������ �Ἥ ĭ�� �°� �������� ��ǥ���� ����ϰ� ������ ����ϴ� ����ü
    public Vector2Int vector2Int;
    public Vector3Int vector3Int;
    //Vector4�� int�ø�� ����

    //4. Color �ø��� : ���� ǥ���ϱ� ���� ���.
    public Color color; // r,g,b,a(����) ���� �Ǽ�(float)�̸�, 0~1�� �����ϰ� ���� 1�� �Ѿ�� ���� ���Ⱑ �������� ȿ���� �ش�
    public Color32 color32; //r,g,b,a���� byte�̸�, 0~255������ ���� ����.
    public Gradient gradient; //�׶��̼� ǥ���� ���� ����ü

    //5. AnimationCurve : �ִϸ��̼��� �ڿ������� ������ ���� Inspector���� �Է��ϱ� ���� ����ü.
    public AnimationCurve curve;  //����ü�� �ƴϰ� Ŭ������ ��..

    //6. �׿�
    public Bounds bounds;
    public Rect rect; // ���簢��
    public LayerMask layerMask;

    void Start()
    {
        Debug.Log(vector2);
        Debug.Log(vector3);
        Debug.Log(vector4);
        Debug.Log(color);
        Debug.Log(color32);
        Debug.Log(curve);
        Debug.Log(bounds);
        Debug.Log(rect);
        Debug.Log(layerMask);
    }

    // Update is called once per frame
}
