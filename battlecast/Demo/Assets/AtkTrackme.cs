using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkTrackme : MonoBehaviour
{
    public float _Speed = 0.1f;
    public GameObject _delhealth;
    public int ch = 0;
    // Update is called once per frame
    void Update()
    {
        GameObject _MEE = GameObject.Find("Player");
        transform.position = Vector3.MoveTowards(transform.position, _MEE.transform.position, _Speed + Time.deltaTime);

        if (transform.position.y > 3.4f &&ch==0)
        {
            ch = 1;
            _delhealth.gameObject.GetComponent<enemyhealth>().health -= 25;
            Destroy(gameObject);
        }
    }
}
