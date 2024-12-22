using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtk : MonoBehaviour
{
    public float _speed = 0.5f;
    // Update is called once per frame
    void Update()
    {
        GameObject _Me = GameObject.Find("Player");
        transform.position = Vector3.MoveTowards(transform.position, _Me.transform.position, _speed + Time.deltaTime);
    }
}
