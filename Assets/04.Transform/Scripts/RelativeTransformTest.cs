using UnityEngine;

public class RelativeTransformTest : MonoBehaviour
{
    public Transform cube;
    public Transform sphere;

    private MeshRenderer origin;

    void Awake()
    {
        origin = sphere.GetComponent<MeshRenderer>();
    }

    private Transform clone1;
    private Transform clone2;
    private Transform clone3;
    private Transform clone4;
    private Transform clone5;
    private Transform clone6;

    void Start()
    {
        MeshRenderer clone1 = Instantiate(origin);
        clone1.material.color = Color.red;
        this.clone1 = clone1.transform;

        MeshRenderer clone2 = Instantiate(origin);
        clone2.material.color = new Color(1,0.5f,0);
        this.clone2 = clone2.transform;

        MeshRenderer clone3 = Instantiate(origin);
        clone3.material.color = Color.yellow;
        this.clone3 = clone3.transform;

        MeshRenderer clone4 = Instantiate(origin);
        clone4.material.color = Color.blue;
        this.clone4 = clone4.transform;

        MeshRenderer clone5 = Instantiate(origin);
        clone5.material.color = Color.cyan;
        this.clone5 = clone5.transform;

        MeshRenderer clone6 = Instantiate(origin);
        clone6.material.color = Color.green;
        this.clone6 = clone6.transform;
    }






    void Update()
    {
        //cube�� local���¿��� x������ 2��ŭ ������ ��ġ�� ������ǥ�� ���ʹ�.
        //Transform.TransformPoint : ���� Ʈ�������� ���� ���¿��� 2��ŭ ������ ������ǥ ��ȯ.
        clone1.position = cube.TransformPoint(2, 0, 0);



        //cube�� ��ġ�� �������, cube�κ��� x������ 2��ŭ �����̴� ���͸� ������ǥ �������� ��ȯ.
        //transform.TransformVector : ���� Ʈ�������� ��ġ(Position)���� ����
        clone2.position = cube.TransformVector(2, 0, 0);

        //cube scale�� ��� ���� cube�κ��� x������ 2��ŭ �����̴� ���͸� ������ǥ �������� ��ȯ.
        //Transform.TransformDirection : TransformVector ��� ������(scale)���� ����
        clone3.position = cube.TransformDirection(2, 0, 0);


        clone4.position = cube.InverseTransformPoint(sphere.position);
        clone5.position = cube.InverseTransformVector(sphere.position);
        clone6.position = cube.InverseTransformDirection(sphere.position);
      


    }

}
