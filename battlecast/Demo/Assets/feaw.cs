using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feaw : MonoBehaviour
{
    public float _addX, _addY, _addZ;
    public GameObject _toom,_healthDEL;
    public int ch = 0;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(_addX, _addY, _addZ);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 5.073999 && ch ==0)
        {
           
            ch = 1;
            _toom.gameObject.SetActive(true);
            Instantiate(_toom.gameObject,gameObject.transform.position,_toom.transform.rotation);
            _healthDEL.gameObject.GetComponent<enemyhealth>().health -= 45;
            
           
        }
    }
 
}
