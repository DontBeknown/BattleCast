using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class turn01 : MonoBehaviour
{
    public int B1 = 0, B2 = 0 , B3 = 0, B4 = 0, B5 = 0, Sum = 0,Ch=0,ChT= 0;
    GameObject Lo1, Lo2, Lo3, Lo4, Lo5,Beai1, Beai2, Beai3, Beai4, Beai5;
    public GameObject EnBs1, EnBs2, EnBs3, EnBs4, EnLo1, EnLo2, EnLo3, EnLo4,EnB1, EnB2, EnB3, EnB4;
    public GameObject Nextturn;
    public GameObject AllyMon, EnemyMon;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        B1 = GameObject.Find("Hitbox00").GetComponent<lockbeai>().chT;
        B2 = GameObject.Find("Hitbox10").GetComponent<lockbeai>().chT;
        B3 = GameObject.Find("Hitbox20").GetComponent<lockbeai>().chT;
        B4 = GameObject.Find("Hitbox30").GetComponent<lockbeai>().chT;
        B5 = GameObject.Find("Hitbox40").GetComponent<lockbeai>().chT;
        Sum = B1 + B2 + B3 + B4 + B5;
        if (Sum == 5 && Ch == 0)
        {
            Beai1 = GameObject.Find("Hitbox00").GetComponent<lockbeai>().Beai;
            Beai2 = GameObject.Find("Hitbox10").GetComponent<lockbeai>().Beai;
            Beai3 = GameObject.Find("Hitbox20").GetComponent<lockbeai>().Beai;
            Beai4 = GameObject.Find("Hitbox30").GetComponent<lockbeai>().Beai;
            Beai5 = GameObject.Find("Hitbox40").GetComponent<lockbeai>().Beai;

            Lo1 = GameObject.Find("Hitbox00").GetComponent<lockbeai>().Boardlocation;
            Lo2 = GameObject.Find("Hitbox10").GetComponent<lockbeai>().Boardlocation;
            Lo3 = GameObject.Find("Hitbox20").GetComponent<lockbeai>().Boardlocation;
            Lo4 = GameObject.Find("Hitbox30").GetComponent<lockbeai>().Boardlocation;
            Lo5 = GameObject.Find("Hitbox40").GetComponent<lockbeai>().Boardlocation;

            var obj0 = Instantiate(Beai1.gameObject, Lo1.transform.position, Lo1.transform.rotation);
            var obj1 = Instantiate(Beai2.gameObject, Lo2.transform.position, Lo2.transform.rotation);
            var obj2 = Instantiate(Beai3.gameObject, Lo3.transform.position, Lo3.transform.rotation);
            var obj3 = Instantiate(Beai4.gameObject, Lo4.transform.position, Lo4.transform.rotation);
            var obj4 = Instantiate(Beai5.gameObject, Lo5.transform.position, Lo5.transform.rotation);

            //print("hi");
            obj0.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj1.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj2.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj3.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj4.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);

            GameObject.Find("Hitbox10").GetComponent<lockbeai>().enabled = false;
            GameObject.Find("Hitbox10").GetComponent<lockbeai>().enabled = false;
            GameObject.Find("Hitbox20").GetComponent<lockbeai>().enabled = false;
            GameObject.Find("Hitbox30").GetComponent<lockbeai>().enabled = false;
            GameObject.Find("Hitbox40").GetComponent<lockbeai>().enabled = false;

            Instantiate(AllyMon.gameObject, AllyMon.transform.position, AllyMon.transform.rotation);

            
            StartCoroutine(ENturn());

            Ch = 1;
        }

        IEnumerator ENturn()
        {
            yield return new WaitForSeconds(5);

            var obj0 = Instantiate(EnB1.gameObject, EnLo1.transform.position, EnLo1.transform.rotation);
            var obj1 = Instantiate(EnB2.gameObject, EnLo2.transform.position, EnLo2.transform.rotation);
            var obj2 = Instantiate(EnB3.gameObject, EnLo3.transform.position, EnLo3.transform.rotation);
            var obj3 = Instantiate(EnB4.gameObject, EnLo4.transform.position, EnLo4.transform.rotation);

            obj0.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj1.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj2.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj3.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);

            obj0.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            obj1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            obj2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            obj3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            obj0 = Instantiate(EnB1.gameObject, EnBs1.transform.position, EnBs1.transform.rotation);
            obj1 = Instantiate(EnB2.gameObject, EnBs2.transform.position, EnBs2.transform.rotation);
            obj2 = Instantiate(EnB3.gameObject, EnBs3.transform.position, EnBs3.transform.rotation);
            obj3 = Instantiate(EnB4.gameObject, EnBs4.transform.position, EnBs4.transform.rotation);

            obj0.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            obj1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            obj2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            obj3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

            obj0.gameObject.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            obj1.gameObject.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            obj2.gameObject.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            obj3.gameObject.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);

            Instantiate(EnemyMon.gameObject, EnemyMon.transform.position, EnemyMon.transform.rotation);


            yield return new WaitForSeconds(5);

            
            Nextturn.GetComponent<turn02>().enabled = true;
            Nextturn.gameObject.SetActive(true);
            
            ChT = 1;
        }
    }
}
