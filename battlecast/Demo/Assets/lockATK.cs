using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockATK : MonoBehaviour
{
    public float _Speed = 0.5f;
    public GameObject _delhealth;
    public int ch = 0;
    // Update is called once per frame
    void Update()
    {
        GameObject _Enemy = GameObject.Find("Enealth");
        transform.position = Vector3.MoveTowards(transform.position, _Enemy.transform.position, _Speed + Time.deltaTime);



        if (transform.position.y > 3.5f && ch == 0)
        {
            ch = 1;
            _delhealth.gameObject.GetComponent<enemyhealth>().health -= 15;
            Destroy(gameObject);
        }
    }
}
