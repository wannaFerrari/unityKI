using UnityEngine;

public class Rotater : MonoBehaviour
{
    [Tooltip("�ʴ� ȸ�� ����")]
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,rotateSpeed * Time.deltaTime);
    }
}
