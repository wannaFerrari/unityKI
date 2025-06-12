using UnityEngine;

public class CreateAndDestroyTest : MonoBehaviour
{
    public GameObject original;
    public FindMe originalComponent;


    //지울 것들
    private GameObject clone;
    private GameObject childClone;
    private GameObject movedClone;
    private FindMe clonedComponent;
    void Start()
    {
        //original이랑 똑같이 생긴 객체를 하나 생성하고 싶다.
        //GameObject clone = new GameObject("Clone Cube");
        //MeshFilter mf = clone.AddComponent<MeshFilter>();
        //MeshRenderer mr = clone.AddComponent<MeshRenderer>();
        //BoxCollider coll = clone.AddComponent<BoxCollider>();

        //mf.mesh = original.GetComponent<MeshFilter>().mesh;
        //mr.material = original.GetComponent<MeshRenderer>().material;
        //coll.size = original.GetComponent<BoxCollider>().size;
        //coll.center = original.GetComponent<BoxCollider>().center;
        //===================위처럼 복잡한 과정을 거쳐야 복사가 되는 거지만.....

        //그냥 Instantiate를 쓰면 끝이다!
        clone = Instantiate(original); // 그냥 복제
        clone.name = "clone";


        // transform을 파라미터로 전달할 경우, 해당 파라미터의 "자식"으로 생성
        childClone = Instantiate(original, transform);
        childClone.name = "childClone";
        //Vector3와 Quaternion을 파라미터로 전달할 경우, 해당 위치와 각도를 가진 상태로 생성
        movedClone = Instantiate(original, new Vector3(3,2,1), Quaternion.Euler(45,30,90));
        movedClone.name = "movedClone";
        //만약 orinigal이 Component일 경우, 해당 컴포넌트가 붙어있는 gameObject와 같은 형태로 게임 오브젝트를 생성하고,
        //original과 같은 컴포넌트를 반환.

       clonedComponent = Instantiate<FindMe>(originalComponent);
        clonedComponent.message = "이것은 클론입니다.";
        clonedComponent.name = "clonedComponent";
        Invoke("DestroyClones", 3f); // 3초 후에"DestroyClones라는 이름의 메소드를 호출해줌(파라미터가 없어야함.)
    }

    private void DestroyClones()
    {
        //클론 4종을 파괴하자
        //게임 오브젝트를 없앨 경우.
        Destroy(clone); // clone이라는 오브젝트가 파괴될 것인데, 
        print($"{clone.name}을 파괴함"); //NullReferenceException이 떠야할것같은데 안떴다???

        // Destroy메소드는 파라미터를 삭제돼야할 객체로 등록을 한다.
        // 해당 프레임이 끝날때 삭제된다.

        Destroy(childClone, 3f); //3초 후에 childClone 삭제, 마찬가지로 해당 프레임의 가장 마지막에 일괄 삭제

        Destroy(clonedComponent); //만약 파라미터가 GameObject가 아니면, 해당 오브젝트만 딱 삭제.
        //위의 경우, clonedComponent가 Cube(Clone)에 부착된 FindMe 컴포넌트 이므로, 해당 컴포넌트만 삭제.

        //이번 프레임이 아니라, 지금 즉시 객체가 파괴되어야 할 경우가 가끔 있음.
        //예를 들면 유니티에서 싱글톤패턴을 구현한다던가... 

        DestroyImmediate(movedClone); // 즉시 객체가 삭제되어 null이 됨

        if(movedClone == null){
            print("movedClone은 이제 없음");
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
