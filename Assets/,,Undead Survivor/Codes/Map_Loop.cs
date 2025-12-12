using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Map_Loop : MonoBehaviour
{
    Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Awake()
     {
        player = FindAnyObjectByType<Player>();
        
     }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 mapPos = transform.position;
        if (playerPos.x - mapPos.x >=10)
        {
            if (playerPos.x >= 0)
            {
                transform.position += new Vector3(10f, 0, 0);
            }
            transform.position += new Vector3(-10f, 0, 0) * Time.deltaTime;
        }
        if (MathF.Abs(playerPos.y- mapPos.y)>= 10)
        {
            if (playerPos.y >= 0)
            {
            transform.position += new Vector3(0,10f, 0) * Time.deltaTime;
            }
            transform.position += new Vector3(0, -10f, 0) * Time.deltaTime;
            
            
        }
    }
}
