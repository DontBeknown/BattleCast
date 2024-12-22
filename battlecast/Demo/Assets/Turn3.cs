using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn3 : MonoBehaviour
{
    public int _sum;
    public GameObject _MonTurn3, _Monlocaton, _MonPJ, _MonPJlo;
    private void OnTriggerEnter(Collider _Hit)
    {

        if (_Hit.gameObject.name == "7(Clone)" || _Hit.gameObject.name == "equal(Clone)" || _Hit.gameObject.name == "minus" || _Hit.gameObject.name == "4(Clone)")
        {
            _sum += 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(_sum >= 4)
        {
            StartCoroutine(_smn3());
            _sum = 0;
        }
    }

    IEnumerator _smn3()
    {
        yield return new WaitForSeconds(1);
        Instantiate(_MonTurn3.gameObject, _Monlocaton.transform.position, _Monlocaton.transform.rotation);
        yield return new WaitForSeconds(1);
        var obj =Instantiate(_MonPJ.gameObject, _MonPJlo.transform.position, _MonPJlo.transform.rotation);
        obj.SetActive(true);
    }
}
