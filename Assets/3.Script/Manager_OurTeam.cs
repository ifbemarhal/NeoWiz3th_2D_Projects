
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Manager_OurTeam : MonoBehaviour
{
    
    public List<GameObject> originalMercenaryPool;
    public List<GameObject> shuffledOurList = new List<GameObject>();
    
    public List<GameObject> ourMarcketPool = new List<GameObject>();
    
    public static Manager_OurTeam ourTeamInstance;

    private Manager_OurTeam()       // private 생성자를 통해서 새로운 Manager_Enemies가 생성되지 않도록
    {

    }


    void Awake()
    {



        if (ourTeamInstance == null)
        {
            // 1. 첫 번째 인스턴스일 경우, 이 인스턴스를 유지
            ourTeamInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 2. 이미 인스턴스가 존재하면, 새로 생성된 자신을 파괴
            Destroy(gameObject);
        }
        shuffledOurList.Clear();
        ourMarcketPool.Clear();
        shuffledOurList.AddRange(originalMercenaryPool);

        List<GameObject> anMercenaryPool = new List<GameObject>(originalMercenaryPool);
        
            
        for (int j = 0; j < originalMercenaryPool.Count; j++)
        {
            int rnd = Random.Range(0, originalMercenaryPool.Count);
           
            // 0에서 전체 용병풀 크기에서 -1한 숫자까지, 0에서부터 시작하니까,Random.Range는 a부터 b미만까지임
            GameObject temp = anMercenaryPool[j];                            // 섞기 위해 필요한 임의의 멤버변수
            anMercenaryPool[j] = anMercenaryPool[rnd];
            anMercenaryPool[rnd] = temp;
            shuffledOurList = anMercenaryPool;



        }


        
            ourMarcketPool.AddRange(shuffledOurList.GetRange(0,8));




       

    }


}


