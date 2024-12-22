using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyhealth : MonoBehaviour
{
    public float health = 100;
    public float maxhealth = 100;

    public GameObject healthBarUI;
    public Slider slider;

    public GameObject win;


    private void Start()
    {
        health = maxhealth;
        slider.value = CalculateHealth();

    }



    private void Update()
    {

        slider.value = CalculateHealth();
        if (health < maxhealth)
        {
            healthBarUI.SetActive(true);
        }
        if (health <= 0)
        {
            //Destroy(gameObject);
        }
        if (health > maxhealth)
        {
            health = maxhealth;
        }

        if (health <= 0 && gameObject.name == "Enemy")
        {
            StartCoroutine(WinUI());
        }
    }

    float CalculateHealth()
    {
        return health / maxhealth;
    }

    void OnCollisionEnter(Collision _collision)
    {
        if (_collision.gameObject.name == "MONSTER-01_PJ 1")
        {
            Destroy(_collision.gameObject);
            health -= 15;
        }
    }

    IEnumerator WinUI()
    {
        yield return new WaitForSeconds(3);

        win.SetActive(true);

    }
}
