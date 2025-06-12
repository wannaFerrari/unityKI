using UnityEngine;

public class UnityStructTest : MonoBehaviour
{
    //유니티 내장 구조체 : 유니티에서 생성된 게임 공간에서 빈번하게 쓰이는 데이터를 구조체로 제공함.

    //1. Vector 시리즈 : 2D, 3D, 4D 차원 상에서의 좌표 또는 힘의 크기를 나타내기 위한 구조체

    public Vector2 vector2;
    public Vector3 vector3;
    public Vector4 vector4;

    //2. Quarternion : 4원수. 3차원의 축값과 1개의 허수부를 사용하여 3차원 공간에서 각도 변경 값이 겹치는
    //"짐벌락"  현상을 방지하기 위해 존재. Transform.Rotation의 기본 자료형이다.
    public Quaternion quaternion;

    //3. VectorInt 시리즈 : 좌표값을 정수로 써서 칸에 맞게 나눠지는 좌표값을 취급하고 싶을때 사용하는 구조체
    public Vector2Int vector2Int;
    public Vector3Int vector3Int;
    //Vector4는 int시리즈가 없음

    //4. Color 시리즈 : 색을 표현하기 위해 사용.
    public Color color; // r,g,b,a(알파) 값이 실수(float)이며, 0~1로 설정하고 값이 1이 넘어가면 빛의 세기가 강해지는 효과를 준다
    public Color32 color32; //r,g,b,a값이 byte이며, 0~255까지만 설정 가능.
    public Gradient gradient; //그라데이션 표현을 위한 구조체

    //5. AnimationCurve : 애니메이션의 자연스러운 움직임 등을 Inspector에서 입력하기 위한 구조체.
    public AnimationCurve curve;  //구조체는 아니고 클래스긴 함..

    //6. 그외
    public Bounds bounds;
    public Rect rect; // 직사각형
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
