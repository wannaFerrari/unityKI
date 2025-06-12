using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 moveDir;
    private void Start()
    {
        Destroy(gameObject, 3f); // GameObject �� �ڽ��� 3�� �Ŀ� ����
    }
    void Update()
    {
        /*
        Vector3 currentPosition = transform.position;
        currentPosition.x += 10 * Time.deltaTime; // Time.deltaTime : �� �����Ӹ��� ���� �����Ӱ��� �ð� ������ ��ȯ 
        //currentPosition.y += moveDir.y * moveSpeed * Time.deltaTime;
        transform.position = currentPosition;
        */
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //�ε��� ��ü�� Enemy������Ʈ�� ������ �������� �ı���
        if (other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            //print($"����� {other.name}�� �浹��");
            if (enemy.hp != 1)
            {
                enemy.hp--;
            }
            else
            {

                Destroy(other.gameObject); // �ε��� ��ü ����
            }

        }
        if (other.CompareTag("Boundary")) //���� ��ȣ�ۿ��� �ݶ��̴��� ������ ������Ʈ�� �±װ� "Boundary���
        {
            Destroy(gameObject); // �� ���� ������Ʈ ����
        }
    }

    
}
