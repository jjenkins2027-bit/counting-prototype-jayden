using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;
    public int scoreValue = 0;
    public int Count = 0;
    //whatever
    private void Start()
    {
        Count = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        Count += 1;
        Count = scoreValue;
        CounterText.text = "Count : " + scoreValue;
    }
    
}
