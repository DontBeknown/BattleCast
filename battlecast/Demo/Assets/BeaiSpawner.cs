using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeaiSpawner : MonoBehaviour
{
    int Turn1 = 0,Ch1 = 0,Ch2 = 0, Turn2 = 0;
    public GameObject Bspwn1, Bspwn2, Bspwn3, Bspwn4, Bspwn5, Bspwn6, Bspwn7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Turn1 = GameObject.Find("Turn1").GetComponent<turn01>().ChT;
        if(Turn1 == 1 && Ch1 == 0)
        {
            var B1 = Instantiate(GameObject.Find("minus"), Bspwn1.transform.position, Bspwn1.transform.rotation);
            var B2 = Instantiate(GameObject.Find("equal"), Bspwn2.transform.position, Bspwn2.transform.rotation);
            var B3 = Instantiate(GameObject.Find("8"), Bspwn3.transform.position, Bspwn3.transform.rotation);
            var B4 = Instantiate(GameObject.Find("9"), Bspwn4.transform.position, Bspwn4.transform.rotation);
            var B5 = Instantiate(GameObject.Find("0"), Bspwn5.transform.position, Bspwn5.transform.rotation);

            B1.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B2.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B3.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B4.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B5.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);

            B1.name = "minus";
            B2.name = "equal";
            B3.name = "8";
            B4.name = "9";
            B5.name = "0";
            Ch1 = 1;
        }
        Turn2 = GameObject.Find("Turn2").GetComponent<turn02>().ChT;
        if(Turn2 == 1 && Ch2 == 0)
        {
            var B1 = Instantiate(GameObject.Find("multiply"), Bspwn1.transform.position, Bspwn1.transform.rotation);
            var B2 = Instantiate(GameObject.Find("equal"), Bspwn2.transform.position, Bspwn2.transform.rotation);
            var B3 = Instantiate(GameObject.Find("12"), Bspwn3.transform.position, Bspwn3.transform.rotation);
            var B4 = Instantiate(GameObject.Find("divide"), Bspwn4.transform.position, Bspwn4.transform.rotation);
            var B5 = Instantiate(GameObject.Find("18"), Bspwn6.transform.position, Bspwn6.transform.rotation);

            B1.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B2.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B3.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B4.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);
            B5.transform.localScale = new Vector3(1.576455f, 1.576455f, 1.576455f);

            B1.name = "multiply";
            B2.name = "equal";
            B3.name = "12";
            B4.name = "divide";
            B5.name = "18";
            Ch2 = 1;
        }
    }
}
