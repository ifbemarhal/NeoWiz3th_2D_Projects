using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CompanyWeaponsManager : MonoBehaviour
{
    public GameObject company = new GameObject();
    [SerializeField]
    public List<GameObject> CompanyWeaponTotalList = new List<GameObject>();
    [SerializeField]
    public string OwnerWeapon=null;
    private GameObject weapon;
    bool boolWeapon = true;
    public CompanySpawner companySpawner;
    public Vector3 playerPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        company = companySpawner.company;
        playerPos = companySpawner.playerPos;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OwnerWeapon != null && boolWeapon==true)
        {
            Debug.Log("오우너웨폰에 값이 들어왔음");
            boolWeapon = false;
            StartCoroutine(Bullet_0());
            // 해당 동료의 포지션에서 플레이어의 포지션을 빼면 방향이 나옴, 노말라이즈 붙여서 방향값 정수로 변환(-1~1)
            // 해당 동료의 자식으로 무기를 생성후 로컬 좌표로 위에서 구한 방향으로 동료에게 안 겹치는 위치에 무기를
            // 위치시킴
        }

    }
    IEnumerator Bullet_0()
    {
        
        weapon =Instantiate(CompanyWeaponTotalList[0], company.transform);
        weapon.transform.localPosition = new Vector3(-1.0f, 1.0f, 0);
        
        
        yield return new WaitForSeconds(0.5f);
        Destroy(weapon);
        yield return new WaitForSeconds(0.5f);
        boolWeapon = true;
    }

    IEnumerator Bullet_1()
    {
        weapon = Instantiate(CompanyWeaponTotalList[1], company.transform);
        weapon.transform.localPosition = new Vector3(-1.0f, 1.0f, 0);


        yield return new WaitForSeconds(0.5f);
        Destroy(weapon);
        yield return new WaitForSeconds(0.5f);
        boolWeapon = true;
    }

    IEnumerator Weapon_0()
    {
        weapon = Instantiate(CompanyWeaponTotalList[2], company.transform);
        weapon.transform.localPosition = new Vector3(-1.0f, 1.0f, 0);


        yield return new WaitForSeconds(0.5f);
        Destroy(weapon);
        yield return new WaitForSeconds(0.5f);
        boolWeapon = true;
    }
}
