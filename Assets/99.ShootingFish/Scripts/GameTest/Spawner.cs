using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //적을 스폰하도록 할 예정
    public float interval; // 생성간격(초)
    public GameObject[] enemyPrefab;

    int enemySelect;
    private float lastSpawnTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.time : 게임이 시작된 이후 초 단위로 누적되는 시간
        if(Time.time > lastSpawnTime + interval)
        {
            //유니티의 Random 클래스.
            //System.Random random = new System.Random();
            //random.Next();
            Vector3 spawnPosition = Random.insideUnitCircle * 5;

            enemySelect = Random.Range(0, enemyPrefab.Length);

            //한번 소환 하고
            Instantiate(enemyPrefab[enemySelect], spawnPosition, Quaternion.identity);

            //마지막 소환 시간을 갱신
            lastSpawnTime = Time.time;


        }
    }
}
