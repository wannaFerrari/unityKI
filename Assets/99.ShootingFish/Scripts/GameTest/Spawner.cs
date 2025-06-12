using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //���� �����ϵ��� �� ����
    public float interval; // ��������(��)
    public GameObject[] enemyPrefab;

    int enemySelect;
    private float lastSpawnTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.time : ������ ���۵� ���� �� ������ �����Ǵ� �ð�
        if(Time.time > lastSpawnTime + interval)
        {
            //����Ƽ�� Random Ŭ����.
            //System.Random random = new System.Random();
            //random.Next();
            Vector3 spawnPosition = Random.insideUnitCircle * 5;

            enemySelect = Random.Range(0, enemyPrefab.Length);

            //�ѹ� ��ȯ �ϰ�
            Instantiate(enemyPrefab[enemySelect], spawnPosition, Quaternion.identity);

            //������ ��ȯ �ð��� ����
            lastSpawnTime = Time.time;


        }
    }
}
