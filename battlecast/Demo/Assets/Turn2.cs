using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn2 : MonoBehaviour
{
    public int _sum=0,_Chturn2=0,ch;
    public GameObject _LastTurn;
    public GameObject _MonTurn2, _Monlocaton,_MonPJ, _MonPJlo, _EnemyMonTurn1, _EnemyMonlocaton, _EnMonPJ, _EnMonPJlo;
    public GameObject _EnemyBeai1, _EnemyBeai2;
    public GameObject _EnemyLock1, _EnemyLock2;
    public GameObject _EnemySpwn1, _EnemySpwn2;
    public GameObject _NewBeai1, _NewBeai2, _NewBeai3, _NewBeai4;
    public GameObject _NewBeailo1, _NewBeailo2, _NewBeailo3, _NewBeailo4;
    public GameObject _HealthDel;
    private void OnTriggerEnter(Collider _Hit)
    {
        
        if (_Hit.gameObject.name == "6(Clone)" || _Hit.gameObject.name == "divide" || _Hit.gameObject.name == "2(Clone)" || _Hit.gameObject.name == "3(Clone)")
        {
            _sum += 1;
        }

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        /*if (_LastTurn.gameObject.GetComponent<Turn1>()._ChTurn1 == 1)
        {
            gameObject.SetActive(true);
        }
        else if (_LastTurn.gameObject.GetComponent<Turn1>()._ChTurn1 == 0)
        {
            gameObject.SetActive(false);
        }*/
        if (_sum >= 4)
        {
            StartCoroutine(_smn2());
            _sum = 0;
        }

        IEnumerator _smn2()
        {
            yield return new WaitForSeconds(1);
            Instantiate(_MonTurn2.gameObject, _Monlocaton.transform.position, _Monlocaton.transform.rotation);
            yield return new WaitForSeconds(1);
            var dj =Instantiate(_MonPJ.gameObject, _MonPJlo.transform.position, _MonPJlo.transform.rotation);
            _HealthDel.gameObject.GetComponent<enemyhealth>().health -= 50;
            yield return new WaitForSeconds(1);
            Destroy(dj);

            yield return new WaitForSeconds(2);
            _EnemyBeai1.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _EnemyBeai2.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            Instantiate(_EnemyBeai1.gameObject, _EnemyLock1.transform.position, _EnemyLock1.transform.rotation);
            Instantiate(_EnemyBeai2.gameObject, _EnemyLock2.transform.position, _EnemyLock2.transform.rotation);
            _EnemyBeai1.gameObject.transform.localScale = new Vector3(19.34923f, 19.34924f, 19.34925f);
            _EnemyBeai2.gameObject.transform.localScale = new Vector3(19.34923f, 19.34924f, 19.34925f);
            Instantiate(_EnemyBeai1.gameObject, _EnemySpwn1.transform.position, _EnemySpwn1.transform.rotation);
            Instantiate(_EnemyBeai2.gameObject, _EnemySpwn2.transform.position, _EnemySpwn2.transform.rotation);

            yield return new WaitForSeconds(1);
            Instantiate(_EnemyMonTurn1.gameObject, _EnemyMonlocaton.transform.position, _EnemyMonlocaton.transform.rotation);
            yield return new WaitForSeconds(1);
            var obj = Instantiate(_EnMonPJ.gameObject, _EnMonPJlo.transform.position, _EnMonPJlo.transform.rotation);
            obj.SetActive(true);

            yield return new WaitForSeconds(1);
            _NewBeai1.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _NewBeai2.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _NewBeai3.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            _NewBeai4.gameObject.transform.localScale = new Vector3(1.513906f, 1.513906f, 1.513906f);
            Instantiate(_NewBeai1.gameObject, _NewBeailo1.transform.position, _NewBeailo1.transform.rotation);
            Instantiate(_NewBeai2.gameObject, _NewBeailo2.transform.position, _NewBeailo2.transform.rotation);
            Instantiate(_NewBeai3.gameObject, _NewBeailo3.transform.position, _NewBeailo3.transform.rotation);
            Instantiate(_NewBeai4.gameObject, _NewBeailo4.transform.position, _NewBeailo4.transform.rotation);

            _Chturn2 = 1;
        }
    }
}
