using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    public Vector3 val = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position,new Vector3( player.transform.position.x,player.transform.position.y,-10),ref val,0.5f);
    }
}
