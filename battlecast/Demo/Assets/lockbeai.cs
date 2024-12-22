using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class lockbeai : MonoBehaviour
{
    int ch = 0;
    public int chT = 0;
    string objname;
    public GameObject obj0,Boardlocation,Beai;
    
    // Start is called before the first frame update
    void Start()
    {
        /*if( gameObject.name == "Hitbox11"  || gameObject.name == "Hitbox1-1" || gameObject.name == "Hitbox1-2" || gameObject.name == "Hitbox1-3")
        {
            gameObject.SetActive(false);
            gameObject.GetComponent<lockbeai>().enabled = false;
        }*/
    }
    void Update()
    {
        /*if( GameObject.Find("Turn1").GetComponent<turn01>().ChT == 1)
        {
            //print("Test");
            gameObject.SetActive(true);
            gameObject.GetComponent<lockbeai>().enabled = true;
        }*/
    }

        private void OnTriggerEnter(Collider _Vang)
    {
        if (_Vang.gameObject.name.Length < 7 && ch == 0 )
        {
            
            if (_Vang.gameObject.name == "9" && obj0.gameObject.name == "Hitbox00") { chT = 1; }
            if (_Vang.gameObject.name == "plus" && obj0.gameObject.name == "Hitbox10") { chT = 1; }
            if (_Vang.gameObject.name == "3" && obj0.gameObject.name == "Hitbox20") { chT = 1; }
            if (_Vang.gameObject.name == "equal" && obj0.gameObject.name == "Hitbox30") { chT = 1; }
            if (_Vang.gameObject.name == "12" && obj0.gameObject.name == "Hitbox40") { chT = 1; }

            if (_Vang.gameObject.name == "8" && obj0.gameObject.name == "Hitbox11") { chT = 1; }
            if (_Vang.gameObject.name == "1" && obj0.gameObject.name == "Hitbox1-1") { chT = 1; }
            if (_Vang.gameObject.name == "equal" && obj0.gameObject.name == "Hitbox1-2") { chT = 1; }
            if (_Vang.gameObject.name == "9" && obj0.gameObject.name == "Hitbox1-3") { chT = 1; }

            if (_Vang.gameObject.name == "equal" && obj0.gameObject.name == "Hitbox-50") { chT = 1; }
            if (_Vang.gameObject.name == "12" && obj0.gameObject.name == "Hitbox-60") { chT = 1; }

            objname = _Vang.gameObject.name;
            
            Destroy(_Vang.gameObject);
            ch = 1;
            var obj = Instantiate(_Vang.gameObject, gameObject.transform.position, gameObject.transform.rotation);
            obj.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            obj.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            Beai = obj.gameObject;

        }
    }

    private void OnTriggerExit(Collider _Vang)
    {
        ch = 0;
        chT = 0;
        _Vang.name = objname;
        _Vang.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
