
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CompanySpawner : MonoBehaviour
{
    public GameObject player;
    [SerializeField]

    Vector3 aroundPlayer;
    Manager_OurTeam manager_ourTeam;
    public GameObject company;
    public Vector3 playerPos;






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {

        manager_ourTeam = Manager_OurTeam.ourTeamInstance;
        // 동료가 생성될 위치 - 플레이어 위치 기준으로 추가 값
        playerPos = player.transform.position;


        // 동료는 4명만
        for (int i = 0; i < 4; i++)
        {

            if (i == 0)
            {
                company = Instantiate(manager_ourTeam.ourMarcketPool[i], playerPos += new Vector3(-0.5f, 0.5f, 0), Quaternion.identity);
                company.transform.parent = player.transform;
                //company = Instantiate(manager_ourTeam.ourMarcketPool[i], player.transform);
                //company.transform.localPosition = new Vector3(-0.5f,0.5f,0);
                company.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                company.GetComponent<SpriteRenderer>().flipX = player.transform.position.x < company.transform.position.x;
                int ignoreLayerNum = LayerMask.NameToLayer("IgnoreCompany");
                company.layer = ignoreLayerNum; // 레이어로 플레이어와 동료간의 물리작용 방지
                GivetheWeapon(company.name);


            }
            else if (i == 1)
            {
                company = Instantiate(manager_ourTeam.ourMarcketPool[i], player.transform);
                company.transform.localPosition = new Vector3(0.5f, 0.5f, 0);
                company.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                company.GetComponent<SpriteRenderer>().flipX = player.transform.position.x < company.transform.position.x;
                int ignoreLayerNum = LayerMask.NameToLayer("IgnoreCompany");
                company.layer = ignoreLayerNum; // 레이어 간의 물리 무시 및 관계는 유니티 메뉴의 프로젝트 세팅에서 관리
                GivetheWeapon(company.name);
            }
            else if (i == 2)
            {
                company = Instantiate(manager_ourTeam.ourMarcketPool[i], player.transform);
                company.transform.localPosition = new Vector3(-0.5f, -0.5f, 0);
                company.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                company.GetComponent<SpriteRenderer>().flipX = player.transform.position.x < company.transform.position.x;
                int ignoreLayerNum = LayerMask.NameToLayer("IgnoreCompany");
                company.layer = ignoreLayerNum;
                GivetheWeapon(company.name);
            }
            else if (i == 3)
            {
                company = Instantiate(manager_ourTeam.ourMarcketPool[i], player.transform);
                company.transform.localPosition = new Vector3(0.5f, -0.5f, 0);
                company.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
                company.GetComponent<SpriteRenderer>().flipX = player.transform.position.x < company.transform.position.x;
                company.layer = 6; // 레이어로 플레이어와 동료간의 물리작용 방지 (레이어 넘버 직접 넣는 방식)
                GivetheWeapon(company.name);
            }

        }





    }

    void GivetheWeapon(string companyName)
    {

        Debug.Log("기브더 웨폰 실행됨");

        for (int i = 0; i < manager_ourTeam.ourMarcketPool.Count; i++)
        {
            if(companyName== manager_ourTeam.ourMarcketPool[i].name)
            {

            
                
                    company.AddComponent<CompanyWeaponsManager>();
                    company.GetComponent<CompanyWeaponsManager>().OwnerWeapon = companyName;
                
            }
           

        }
    }
    


}

    








