using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasFallen2 : MonoBehaviour
{
    public int count = 0;
    public bool done1 = false;
    public bool done2 = false;
    public bool done3 = false;
    public bool done4 = false;
    public bool done5 = false;
    public bool done6 = false;
    public bool done7 = false;
    public bool done8 = false;
    public bool done9 = false;
    public bool done10 = false;


    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public GameObject pin4;
    public GameObject pin5;
    public GameObject pin6;
    public GameObject pin7;
    public GameObject pin8;
    public GameObject pin9;
    public GameObject pin10;

    private void Start()
    {
        
    }
    void Update()

    {
        if (pin1.transform.rotation.eulerAngles.y > 40 && done1 == false)
        {
            count++;
            done1 = true;
            ScoreManager.instance.AddPoint();

        }

        if (pin2.transform.rotation.eulerAngles.y > 40 && done2 == false)
        {
            count++;
            done2 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin3.transform.rotation.eulerAngles.y > 40 && done3 == false)
        {
            count++;
            done3 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin4.transform.rotation.eulerAngles.y > 40 && done4 == false)
        {
            count++;
            done4 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin5.transform.rotation.eulerAngles.y > 40 && done5 == false)
        {
            count++;
            done5 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin6.transform.rotation.eulerAngles.y > 40 && done6 == false)
        {
            count++;
            done6 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin7.transform.rotation.eulerAngles.y > 40 && done7 == false)
        {
            count++;
            done7 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin8.transform.rotation.eulerAngles.y > 40 && done8 == false)
        {
            count++;
            done8 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin9.transform.rotation.eulerAngles.y > 40 && done9 == false)
        {
            count++;
            done9 = true;
            ScoreManager.instance.AddPoint();
        }

        if (pin10.transform.rotation.eulerAngles.y > 40 && done10 == false)
        {
            count++;
            done10 = true;
            ScoreManager.instance.AddPoint();
        }

        print("Es sind " +count + " pins gefallen");
        
    }
}

