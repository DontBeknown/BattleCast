using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockandTP : MonoBehaviour
{
    public int ch1 = 0;
    public GameObject _Lock,_Spwn;
    
    void Start()
    {

    }
    private void OnTriggerEnter(Collider _Vang)
    {
        if(_Vang.gameObject.name.Length > 0 && ch1 == 0 )
        {
            ch1 = 1;
            Destroy(_Vang.gameObject);
            
            var obj = Instantiate(_Vang.gameObject, _Lock.transform.position, _Lock.transform.rotation);
            obj.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            
            
            
            var obj2 = Instantiate(_Vang.gameObject, _Spwn.transform.position, _Spwn.transform.rotation);
            obj2.transform.localScale = new Vector3(19.34923f, 19.34924f, 19.34925f);

           
            
        }
    }



}
