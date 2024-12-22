using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATKarrow : MonoBehaviour
{
    public float _Speed=0.5f;
    public int ch = 0;
    public GameObject _delhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject _Enemy = GameObject.Find("Enealth");
        transform.position = Vector3.MoveTowards(transform.position, _Enemy.transform.position, _Speed + Time.deltaTime);

        if(transform.position.y > 3.7 && ch == 0)
        {
            ch = 1;
            _delhealth.gameObject.GetComponent<enemyhealth>().health -= 35;
            Destroy(gameObject);
        }
    }
}
