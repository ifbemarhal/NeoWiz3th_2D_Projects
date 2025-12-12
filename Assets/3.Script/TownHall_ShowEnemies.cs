using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownHall_ShowEnemies : MonoBehaviour
{
    public Manager_Enemies manager_Enemies;

    SpriteRenderer spriteRenderer;
    public GameObject UIImage0;
    public GameObject UIImage1;
    public GameObject UIImage2;
    public GameObject UIImage3;

    //public Sprite sprite0;
    //public Sprite sprite1;
    //public Sprite sprite2;
    //public Sprite sprite3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created



    void Start()
    {
        // sprite0=Instantiate(enemyManager.enemyFirstTeam[0].GetComponent<SpriteRenderer>().sprite);

        //   UIImage0
        // UIImage0.GetComponent<Image>() = enemyManager.enemyFirstTeam[0].GetComponent<SpriteRenderer>().sprite;
        //       gameObject.Add(Instantiate(enemyManager.enemyFirstTeam[0],UIImage0.transform));
        //   UIImage0 = gameObject[0];
        UIImage0.GetComponent<Image>().sprite = Instantiate(manager_Enemies.enemyFirstTeam[0].GetComponent<SpriteRenderer>().sprite);
        UIImage1.GetComponent<Image>().sprite = Instantiate(manager_Enemies.enemyFirstTeam[1].GetComponent<SpriteRenderer>().sprite);
        UIImage2.GetComponent<Image>().sprite = Instantiate(manager_Enemies.enemyFirstTeam[2].GetComponent<SpriteRenderer>().sprite);
        UIImage3.GetComponent<Image>().sprite = Instantiate(manager_Enemies.enemyFirstTeam[3].GetComponent<SpriteRenderer>().sprite);


    }


}