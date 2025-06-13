using UnityEngine;

public class Rotater : MonoBehaviour
{
    [Tooltip("초당 회전 각도")]
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotateSpeed * Time.deltaTime);
    }
}
