using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Reposition : MonoBehaviour
{
    private void Start()
    {
       
    }
    private void Update()
    {
        Vector3 playerPos = GameManager.instance.player.transform.position;
        Vector3 myPos = transform.position;
        if (MathF.Abs(playerPos.x-myPos.x)> MathF.Abs(playerPos.y - myPos.y))
        {

            if (playerPos.x - myPos.x > 22)
            {
                transform.position += new Vector3(44f, 0, 0);
            }
            if (playerPos.x - myPos.x < -22)
            {
                transform.position += new Vector3(-44f, 0, 0);
            }
        }
        else if (MathF.Abs(playerPos.x - myPos.x) < MathF.Abs(playerPos.y - myPos.y))
        {

            if (playerPos.y - myPos.y > 22)
            {
                transform.position += new Vector3(0, 44f, 0);
            }
            if (playerPos.y - myPos.y < -22)
            {
                transform.position += new Vector3(0, -44f, 0);
            }
        }
        else
        {
            if (playerPos.x - myPos.x > 22)
            {
                transform.position += new Vector3(44f, 0, 0);
            }
            if (playerPos.x - myPos.x < -22)
            {
                transform.position += new Vector3(-44f, 0, 0);
            }
            if (playerPos.y - myPos.y > 22)
            {
                transform.position += new Vector3(0, 44f, 0);
            }
            if (playerPos.y - myPos.y < -22)
            {
                transform.position += new Vector3(0, -44f, 0);
            }
        }
    }


    //void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (!collision.CompareTag("Area"))
    //        return;
    //    Vector3 playerPos = GameManager.instance.player.transform.position;
    //    Vector3 myPos = transform.position;
    //    float diffX = Mathf.Abs(playerPos.x - myPos.x);
    //    float diffY = Mathf.Abs(playerPos.y - myPos.y);
    //
    //    Vector3 playerDir = GameManager.instance.player.inputVec;
    //    float dirX = playerDir.x < 0 ? -1 : 1;
    //    float dirY = playerDir.y < 0 ? -1 : 1;
    //
    //    switch (transform.tag)
    //    {
    //        case "Ground":
    //            if (diffX > diffY)
    //            {
    //                transform.Translate(Vector3.right * dirX * 44);
    //            }
    //            else if (diffX<diffY)
    //            {
    //                transform.Translate(Vector3.up * dirY * 44);
    //            }
    //            break;
    //        case "Enemy":
    //    
    //            break;
    //    }
    //
    //    
    //
    //
    //}
   

        
   
}
