using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class Moving : MonoBehaviour
{
    public bool forward;
    private bool stopRand = false;
    public InputField n;
    private Vector3[] array;
    public Object men1;
    public Transform point1;
    public Transform point2;
    private Vector3 target;
    public float speed;
    private int endN = 0;
    private int random, random2;
    private int beginN;
    void Start()
    {
       
    }

       void Update()
    {
        if (n != null && stopRand == false)
        {
            FillArray();
            stopRand = true;
        }
        MoveMen();       
    }
    private void MoveMen()
    {
        transform.LookAt(target);
        if (forward == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

            if (transform.position == target)
            {
                if (endN > 0)
                {
                    endN--;
                    target = array[endN];
                    Debug.Log(endN);
                }
            }
        }
        if (forward == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

            if (transform.position == target)
            {
                if (endN < beginN - 1)
                {
                    endN++;
                    target = array[endN];
                    Debug.Log(endN);
                }
            }
        }
    }
    private void FillArray()
    {
        endN = int.Parse(n.text);
        beginN = endN;
        
        array = new Vector3[endN];

        for (int i = 0; i < endN; ++i)
        {
            random = UnityEngine.Random.Range(-5, 5);
            random2 = UnityEngine.Random.Range(-5, 5);
            array[i] = new Vector3(random, 0, random2);
           
        }
    }

}
