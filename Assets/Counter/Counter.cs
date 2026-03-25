using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;
    public static int Count = 0;
    public int scoreMultiplier;
    //whatever
    private void Start()
    {
        Count = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        Count += 1 * scoreMultiplier;

        CounterText.text = "Count : " + Count;
        Destroy(other.gameObject);
    }
    
}
