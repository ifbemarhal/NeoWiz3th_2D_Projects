
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Manager_Enemies : MonoBehaviour
{
    public List<GameObject> originalMercenaryPool;
    public List<GameObject> enemyListTotal = new List<GameObject>();
    [SerializeField]
    public  List<GameObject> enemyFirstTeam = new List<GameObject>();
    [SerializeField]
    public  List<GameObject> enemySecondTeam = new List<GameObject>();
    [SerializeField]
    public  List<GameObject> enemyThirdTeam = new List<GameObject>();
    public static Manager_Enemies EnemyInstance;
    
    private Manager_Enemies()       // private 생성자를 통해서 새로운 Manager_Enemies가 생성되지 않도록
    {

    }


    void Awake()
    {
        


        if (EnemyInstance == null)
        {
            // 1. 첫 번째 인스턴스일 경우, 이 인스턴스를 유지
            EnemyInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 2. 이미 인스턴스가 존재하면, 새로 생성된 자신을 파괴
            Destroy(gameObject);
        }
        enemyListTotal.Clear();
        enemyFirstTeam.Clear();
        enemySecondTeam.Clear();
        enemyThirdTeam.Clear();

        enemyListTotal.AddRange(originalMercenaryPool);


        List<GameObject> anMercenaryPool = new List<GameObject>(originalMercenaryPool);
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < originalMercenaryPool.Count; j++)
            {
                int rnd = Random.Range(0, originalMercenaryPool.Count);
               
                // 0에서 전체 용병풀 크기에서 -1한 숫자까지, 0에서부터 시작하니까,Random.Range는 a부터 b미만까지임
                GameObject temp = anMercenaryPool[j];                            // 섞기 위해 필요한 임의의 멤버변수
                anMercenaryPool[j] = anMercenaryPool[rnd];
                anMercenaryPool[rnd] = temp;
                enemyListTotal = anMercenaryPool;


            }
        }

        




            for (int i = 0; i < 4; i++)                             // 첫번째 적 팀에 섞인 풀에서 0~3
        {
            enemyFirstTeam.Add(enemyListTotal[i]);
        } 
        for (int i = 4; i < 8; i++)                             // 두번째 적 팀에 섞인 풀에서 4~7
        {
            enemySecondTeam.Add(enemyListTotal[i]);
        } 
        for (int i = 8; i < 12; i++)                            // 세번째 적 팀에 섞인 풀에서 7~11
        {
            enemyThirdTeam.Add(enemyListTotal[i]);
        }
       
    }

   
}
