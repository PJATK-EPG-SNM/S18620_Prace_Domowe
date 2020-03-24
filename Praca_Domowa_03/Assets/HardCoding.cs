using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCoding : MonoBehaviour
{
    int i;
    float f;
    bool jump;
    bool stand;
    string str1;
    string str2;
    void Start()
    {
        Zadanie4(2, 5f, false, true, "Programuje w C#", "EPG");

        Zadanie5(2,5f);

        Zadanie6("Programuje w C#", "Programuje w C#");

        Zadanie7(true, false);








    }

    void Zadanie4(int i,float f, bool jump,bool stand, string str1, string str2)
    {
        Debug.Log("int i= " + i + "| float f= " + f + "| bool jump= " + jump + "| bool stand= " + stand + "| string1 = " + str1 + "| string2 = " + str2);
    }

    void Zadanie5(int i, float f)
    {
        if (i == f)
        {
            Debug.Log("Są równe");
        }
        else
        {
            if (i != f)
            {
                Debug.Log("Są różne");
            }

        }

        if (i > f)
        {
            Debug.Log("Pierwsza jest większa");
        }
        else
        {
            Debug.Log("Druga jest większa");
        }


        if (i >= f)
        {
            Debug.Log("Pierwsza jest większa lub równa");
        }
        else
        {
            if (i <= f)
            {
                Debug.Log("Druga jest większa lub równa");
            }
        }
    }

    void Zadanie6(string str1,string str2)
    {
        if (string.Equals(str1, str2) == false)
        {
            Debug.Log("Różne");
        }
    }

    void Zadanie7(bool jump, bool stand)
    {
        //bool &&

        if (jump == true && stand == true)
        {
            Debug.Log("true");
        }

        if (jump == true && stand == false)
        {
            Debug.Log("false");
        }

        if (jump == false && stand == true)
        {
            Debug.Log("false");
        }

        if (jump == false && stand == false)
        {
            Debug.Log("false");
        }
        
        //bool ||

        if (jump == true || stand == true)
        {
            Debug.Log("true");
        }

        if (jump == true || stand == false)
        {
            Debug.Log("true");
        }

        if (jump == false || stand == true)
        {
            Debug.Log("true");
        }

        if (jump == false || stand == false)
        {
            Debug.Log("false");
        }
    }
    

   
}
