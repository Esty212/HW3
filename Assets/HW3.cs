using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW3 : MonoBehaviour
{


    void Start()
    {

        int num = Random.Range(0, 10);
        SwitchInt(num);
        Number(num);

    }


    void Number(int num)
    {
        if (num < 6)
        {
            Debug.Log("The number is smaller than 6");
        }
        else
        {
            Debug.Log("The number is bigger than 6");

        }

    }

    void SwitchInt(int num)
    {
        switch (num)
        {
            case 7:
                Debug.Log("The number is 7");
                break;
            case 8:
                Debug.Log("The number is 8");
                break;
            case 9:
                Debug.Log("The number is 9");
                break;

            default:
                Debug.Log("No matching number");
                break;

        }
    }



}
