using UnityEngine;

public class ComponentFindTest : MonoBehaviour
{
    //게임 오브젝트를 알고 있는 상태에서, 그 오브젝트에 부착된 특정 컴포넌트를 찾으려 할 경우.
    public GameObject target;
    public Sprite someSprite;
    void Start()
    {
        //target 오브젝트에서 FindMe 컴포넌트를 가져오려면
        FindMe findMe = target.GetComponent<FindMe>();
        print(findMe.message);
        bool isFinded = target.TryGetComponent<SpriteRenderer>(out SpriteRenderer spRenderer);

        if (isFinded)
        {
            //컴포넌트를 찾는데 성공
            spRenderer.sprite = someSprite;
        }
        else
        {
            //컴포넌트를 못찾음.
            print("찾는 컴포넌트가 없습니다.");
        }
        isFinded = target.TryGetComponent<Collider2D>(out Collider2D coll);
        if (isFinded)
        {
            //컴포넌트를 찾는데 성공
            print(coll.offset);
        }
        else
        {
            //컴포넌트를 못찾음.
            print("찾는 컴포넌트가 없습니다.");
        }

        //Hierarchy상 자식 오브젝트들에 붙어있는 컴포넌트들도 찾을 수 있다.
        FindMe[] children = target.GetComponentsInChildren<FindMe>(true);
        //자기 자신에 부착된 컴포넌트를 포함한다.
        //오버로드 된 메소드 중, includeInactive를 true로 전달하면 비활성화 된 자식도 포함.

        foreach (FindMe child in children)
        {
            print(child.message);
        }

        FindMe newFindme = target.AddComponent<FindMe>();
        newFindme.message = "새롭게 나를 찾아주셨군요";
    }
}
