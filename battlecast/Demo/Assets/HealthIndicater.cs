using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIndicater : MonoBehaviour
{
    private Material material;
    private void Start()
    {
        material = GetComponent<Renderer>().material;

        FindObjectOfType<Myhealth>().OnHealthPctChanged += HealthINdicator_OnHealthPctChanged; 
    }

    private void HealthINdicator_OnHealthPctChanged(float pct)
    {
        material.SetFloat("_Cutoff", 1f - pct);
    }
   
}
