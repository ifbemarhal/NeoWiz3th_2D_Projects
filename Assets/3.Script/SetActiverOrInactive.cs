using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SetActiverOrInactive : MonoBehaviour
{
    [SerializeField]
    [Header("활성화 또는 비활성화 대상")]
    public GameObject gameObject;

    void Awake()
    {
       
    }


    public void InActive()
    {
        gameObject.SetActive(false);
    }
    public void Active()
    {
        gameObject.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
