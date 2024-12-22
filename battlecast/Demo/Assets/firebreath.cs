using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebreath : MonoBehaviour
{
    public GameObject PJ, PJLO;
    int ch;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoGo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator GoGo()
    {
        if (ch == 0)
        {
            yield return new WaitForSeconds(3);
            Instantiate(PJ.gameObject, PJLO.transform.position, PJLO.transform.rotation);
            ch = 1;
        }
    }
}
