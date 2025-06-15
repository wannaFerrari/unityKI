using UnityEngine;

public class SelfRotate : MonoBehaviour
{

    public float rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime*5);
    }
}
