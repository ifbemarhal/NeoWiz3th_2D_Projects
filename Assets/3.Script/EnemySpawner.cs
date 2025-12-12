
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour
{
    public GameObject player;
    public float spawnInterval=0.5f;
    public float minSpawnDistance = 18f;
    public float maxSpawnDistance = 36f;
    Vector3 aroundPlayer;
    Manager_Enemies manager_Enemies;
    

    IEnumerator SpawnEnemisRoutine()        //생성용 코루틴
    {
        GameObject newEnemy;
        while (true)
        {
            if (player == null || manager_Enemies == null)
            {
                yield break;
            }
            // 1. 설정된 시간만큼 기다립니다.
            yield return new WaitForSeconds(spawnInterval);
            
            // 2. 적이 생성될 위치를 계산합니다.
            Vector3 playerPos = player.transform.position;

            // Random.Range(min, max)를 사용하여 X와 Y축의 무작위 거리를 계산합니다.
            // X축 무작위 거리 (양수 또는 음수)
            float randX = Random.Range(minSpawnDistance, maxSpawnDistance) * (Random.Range(0, 2) * 2 - 1);
            // Y축 무작위 거리 (양수 또는 음수)
            float randY = Random.Range(minSpawnDistance, maxSpawnDistance) * (Random.Range(0, 2) * 2 - 1);

            // Z축은 0으로 고정
            Vector3 spawnOffset = new Vector3(randX, randY, 0f);
            Vector3 spawnPosition = playerPos + spawnOffset;

            // 3. 적을 enemyFirstTeam에 들어있는 4종류의 적들을 랜덤하게 생성, 생성 위치는 spawnPosition, 회전값은 없음
            newEnemy = Instantiate(manager_Enemies.enemyFirstTeam[Random.Range(0,4)], spawnPosition, Quaternion.identity);
            // 4. 적을 생성하면서 Tracker_Enemy라는 _target 을 쫓아다니는 스크립트를 부여함,
            // 그러면서 _target 에 플레이어의 위치를 바로 넣어서 생성과 함께 플레이어를 쫓아다니도록 기능을 부여함
            newEnemy.AddComponent<Tracker_Enemy>()._target=player.GetComponent<Rigidbody2D>();
            // 5. 레이어는 enemy값을 넣어놓은 레이어이다. 이것은 나중에 공격 사망 판정이 가능하도록 하기 위함이다.
            newEnemy.layer = 3;
            newEnemy.GetComponent<SpriteRenderer>().color = new Color32(255,112,112,255);
            Debug.Log("새로운 적 생성: " + newEnemy.name);

        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
       
        manager_Enemies = Manager_Enemies.EnemyInstance;
        StartCoroutine(SpawnEnemisRoutine());
        
    }



  
   


}

