using UnityEngine;

public class Rotater2 : MonoBehaviour
{
    [Tooltip("�ʴ� ȸ�� ����")]
    public float rotateSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotateSpeed * Time.deltaTime*5,0);
    }
}
