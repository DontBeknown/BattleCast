using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATKtrack : MonoBehaviour
{
    public float _Speed = 0.2f;
    public GameObject _delhealth;
    public int ch = 0,dmg = 0;
    // Update is called once per frame
    void Update()
    {
        GameObject _Enemy = GameObject.Find("Enealth");
        transform.position = Vector3.MoveTowards(transform.position, _Enemy.transform.position, _Speed + Time.deltaTime);

        if(gameObject.name == "MONSTER-01_PJ 1 1(Clone)"  && transform.position.y > 3.5 && ch == 0)
        {
            GameObject.Find("Enemy").GetComponent<enemyhealth>().health -= dmg;
            Destroy(gameObject);
            ch = 1;
        }
        if(transform.position.y > 4  && ch == 0)
        {
            GameObject.Find("Enemy").GetComponent<enemyhealth>().health -= dmg;
            Destroy(gameObject);
            ch = 1;
        }
    }
}
