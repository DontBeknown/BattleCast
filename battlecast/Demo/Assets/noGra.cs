using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class noGra : MonoBehaviour
{
    Rigidbody _Obj;
    void Update()
    {
        _Obj = GetComponent<Rigidbody>();
        if (GameObject.Find("HItBox").GetComponent<LockandTP>().ch1 == 1)
        {
            print("freeze");
            _Obj.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
    }
    
    
}
