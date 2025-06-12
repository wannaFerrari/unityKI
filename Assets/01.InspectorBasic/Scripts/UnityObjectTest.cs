using UnityEngine;

public class UnityObjectTest : MonoBehaviour
{
    public GameObject testObject;
    public Transform cubeTransform;
    public MeshRenderer cubeMeshRenderer;
    public MeshFilter cubeMeshFilter;
    public BoxCollider cubeBoxCollider;
    public object systemObject; //C#(dotnet)의 모든 클래스의 부모
    public Object unityObject; // 유니티 Inspector에서 참조할 수 있는 모든 오브젝트의 부모
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
