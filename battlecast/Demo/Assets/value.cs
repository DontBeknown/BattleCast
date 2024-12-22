using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class value : MonoBehaviour
{
    public GameObject _chip;
    private int _num, _point;

    // Update is called once per frame
    void Update()
    {
        string temp;
        if(gameObject.name.Length == 5)
            temp = gameObject.name.Substring(4,1);
        else
            temp = gameObject.name.Substring(4, 2); 
        int num = int.Parse(temp);
        Debug.Log(num);
        if (num >= 0 && num <= 3) { _point = 1; }
        else if (num >= 4 && num <= 9) { _point = 2; }
        else if (num == 10 && num == 12) { _point = 3; }
        else if (num == 11) { _point = 4; }
        else if (num == 13) { _point = 6; }
        else if (num >= 14 && num <= 16||num==18) { _point = 4; }
        else if (num == 19) { _point = 6; }
        else if (num == 20) { _point = 5; }


    }
}
