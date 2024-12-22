using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exitdagame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            print("exit");
            Application.Quit();
        }
    }
}
