using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn03 : MonoBehaviour
{
    public int B1 = 0, B2 = 0, Sum = 0, Ch = 0, ChT = 0;
    GameObject Lo1, Lo2, Beai1, Beai2;
    public GameObject AllyMon;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Turn03>().enabled = false;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        B1 = GameObject.Find("Hitbox-50").GetComponent<lockbeai>().chT;
        B2 = GameObject.Find("Hitbox-60").GetComponent<lockbeai>().chT;
        Sum = B1 + B2;
        if (Sum == 2 && Ch == 0)
        {
            Beai1 = GameObject.Find("Hitbox-50").GetComponent<lockbeai>().Beai;
            Beai2 = GameObject.Find("Hitbox-60").GetComponent<lockbeai>().Beai;

            Lo1 = GameObject.Find("Hitbox-50").GetComponent<lockbeai>().Boardlocation;
            Lo2 = GameObject.Find("Hitbox-60").GetComponent<lockbeai>().Boardlocation;

            var obj0 = Instantiate(Beai1.gameObject, Lo1.transform.position, Lo1.transform.rotation);
            var obj1 = Instantiate(Beai2.gameObject, Lo2.transform.position, Lo2.transform.rotation);

            obj0.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);
            obj1.gameObject.transform.localScale = new Vector3(29.0317f, 29.03171f, 29.03171f);

            Instantiate(AllyMon.gameObject, AllyMon.transform.position, AllyMon.transform.rotation);


            Ch = 1;
        }
    }
}
