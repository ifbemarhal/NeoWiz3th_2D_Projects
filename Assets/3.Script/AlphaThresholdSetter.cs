using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AlphaThresholdSetter : MonoBehaviour
{
    public Image targetImage;
    public float thresholdValue = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (targetImage != null)
        {
            
            // alphaHitTestMinimumThreshold 설정
            targetImage.alphaHitTestMinimumThreshold = thresholdValue;

            // 이 설정이 작동하려면 Sprite의 Read/Write Enabled가 켜져 있어야 합니다.
            Debug.Log($"Image '{targetImage.name}' alphaHitTestMinimumThreshold set to: {thresholdValue}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
