using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Turn1 : MonoBehaviour
{
    public int _sum = 0, _ChTurn1 = 0, _Ch = 0, _Cnt = 0;
    public GameObject _MonTurn1, _Monlocaton, _EnemyMonTurn1, _EnemyMonlocaton, _EnemyPJ, _EnemyPJlo;
    public GameObject _EnemyBeai1, _EnemyBeai2, _EnemyBeai3, _EnemyBeai4;
    public GameObject _EnemySpwn1, _EnemySpwn2, _EnemySpwn3, _EnemySpwn4;
    public GameObject _EnemyLock1, _EnemyLock2, _EnemyLock3, _EnemyLock4;
    public GameObject _NewBeai1, _NewBeai2, _NewBeai3;
    public GameObject _NewBeailo1, _NewBeailo2, _NewBeailo3;
    public GameObject _MonPJ, _MonPJlo;



    private void OnTriggerEnter(Collider _Hit)
    {
        _Cnt += 1;
        if (_Hit.gameObject.name == "1" || _Hit.gameObject.name == "equal")
        {
            _sum += 1;
        }

    }
    void Update()
    {
        if (_sum >= 3 )
        {
            
            StartCoroutine(_smn1());
            _sum = 0;
        }

        IEnumerator _smn1()
        {
            yield return new WaitForSeconds(1);
            Instantiate(_MonTurn1.gameObject, _Monlocaton.transform.position, _Monlocaton.transform.rotation);
            yield return new WaitForSeconds(1);
            var obj1 = Instantiate(_MonPJ.gameObject, _MonPJlo.transform.position, _MonPJlo.transform.rotation);
            obj1.SetActive(true);

            yield return new WaitForSeconds(3);

            _EnemyBeai1.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _EnemyBeai2.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _EnemyBeai3.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _EnemyBeai4.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            Instantiate(_EnemyBeai1.gameObject, _EnemyLock1.transform.position, _EnemyLock1.transform.rotation);
            Instantiate(_EnemyBeai2.gameObject, _EnemyLock2.transform.position, _EnemyLock2.transform.rotation);
            Instantiate(_EnemyBeai3.gameObject, _EnemyLock3.transform.position, _EnemyLock3.transform.rotation);
            Instantiate(_EnemyBeai4.gameObject, _EnemyLock4.transform.position, _EnemyLock4.transform.rotation);

            _EnemyBeai1.gameObject.transform.localScale = new Vector3(19.34923f, 19.34924f, 19.34925f);
            _EnemyBeai2.gameObject.transform.localScale = new Vector3(19.34923f, 19.34924f, 19.34925f);
            _EnemyBeai3.gameObject.transform.localScale = new Vector3(19.34923f, 19.34924f, 19.34925f);
            _EnemyBeai4.gameObject.transform.localScale = new Vector3(19.34923f, 19.34924f, 19.34925f);
            Instantiate(_EnemyBeai1.gameObject, _EnemySpwn1.transform.position, _EnemySpwn1.transform.rotation);
            Instantiate(_EnemyBeai2.gameObject, _EnemySpwn2.transform.position, _EnemySpwn2.transform.rotation);
            Instantiate(_EnemyBeai3.gameObject, _EnemySpwn3.transform.position, _EnemySpwn3.transform.rotation);
            Instantiate(_EnemyBeai4.gameObject, _EnemySpwn4.transform.position, _EnemySpwn4.transform.rotation);

            yield return new WaitForSeconds(1);
            Instantiate(_EnemyMonTurn1.gameObject, _EnemyMonlocaton.transform.position, _EnemyMonlocaton.transform.rotation);
            yield return new WaitForSeconds(1);
            var obj2 = Instantiate(_EnemyPJ.gameObject, _EnemyPJlo.transform.position, _EnemyPJlo.transform.rotation);
            obj2.SetActive(true);

            yield return new WaitForSeconds(1);
            _NewBeai1.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _NewBeai2.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _NewBeai3.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            Instantiate(_NewBeai1.gameObject, _NewBeailo1.transform.position, _NewBeailo1.transform.rotation);
            Instantiate(_NewBeai2.gameObject, _NewBeailo2.transform.position, _NewBeailo2.transform.rotation);
            Instantiate(_NewBeai3.gameObject, _NewBeailo3.transform.position, _NewBeailo3.transform.rotation);

            _ChTurn1 = 1;
            

        }
    }
}
