using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Myhealth : MonoBehaviour
{
    [SerializeField]
    public int maxHealth = 100;

    public int currentHealth;

    public event Action<float> OnHealthPctChanged = delegate { };

    private void Awake()
    {
        currentHealth = maxHealth;
        //foreach(var controller in GetComponentInChildren<SteamVR_Traced>)
        
    }

     void Update()
    {
        float pct = (float)currentHealth / (float)maxHealth;
        OnHealthPctChanged(pct);
    }
}
