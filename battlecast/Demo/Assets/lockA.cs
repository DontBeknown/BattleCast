using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockA : MonoBehaviour
{
    public int ch = 0;
    private void OnCollisionEnter(Collision _sai)
    {
        if(_sai.gameObject.name =="A"|| _sai.gameObject.name == "T"&&ch==0)
        {
            ch = 1;
            Destroy(_sai.gameObject);
            var obj = Instantiate(_sai.gameObject, gameObject.transform.position, gameObject.transform.rotation);
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
