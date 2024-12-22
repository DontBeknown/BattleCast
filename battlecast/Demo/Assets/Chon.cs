using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chon : MonoBehaviour
{
    public GameObject _spwn, _lock, _smnl, _smn, _atk, _atkl;
    static public int ch = 0;
    public int _summon = 0;

    private void OnCollisionEnter(Collision _Chon)
    {

        //StartCoroutine(play());
        if (_Chon.gameObject.name.Length < 7 && ch == 0)
        {
            _summon += 1;
            //print("S"+_summon);
            //Debug.Log("chonning");
            Destroy(_Chon.gameObject);
            Instantiate(_Chon.gameObject, _lock.transform.position, _lock.transform.rotation);
            _Chon.gameObject.transform.localScale = new Vector3(0.3028907f, 0.003962679f, 0.3112023f);
            Instantiate(_Chon.gameObject, _spwn.transform.position, _spwn.transform.rotation);

            ch = 1;

        }

    }
    void Update()
    {
        ch = 0;

        if (_summon >= 1)
        {
            //print("kuy");

            StartCoroutine(go());
            _summon = 0;

        }

        IEnumerator go()
        {
            yield return new WaitForSeconds(1);

            Instantiate(_smn.gameObject, _smnl.transform.position, _smnl.transform.rotation);
            //_smn.transform.position += new Vector3(0, 1, 0);

            yield return new WaitForSeconds(1);
            Instantiate(_atk.gameObject, _atkl.transform.position, _atkl.transform.rotation);
        }
    }

}//CHON
