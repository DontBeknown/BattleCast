using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chnextscene : MonoBehaviour
{
    public int ch = 0;
    private void OnCollisionEnter(Collision _sai)
    {
        if (_sai.gameObject.name == "A" || _sai.gameObject.name == "T" )
        {
            ch +=1;
            print(ch);
            //Destroy(_sai.gameObject);
            //var obj = Instantiate(_sai.gameObject, gameObject.transform.position, gameObject.transform.rotation);
            //sobj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    private void Update()
    {
        if (ch >= 2)
        {
            SceneManager.LoadScene("BattleCast");
        }
    }

    
}
