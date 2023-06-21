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
    public float speed = 40;
    private int nnn = 0;
    private int random;
    void Start()
    {
        target.Set(4, 0, 0);
        // target = point1.position;
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
        if (forward)
          
                transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

        if (transform.position == target)
        {
            if (nnn > 0)
            {
                nnn--;
                target = array[nnn];
            }            
        }
    }
    private void FillArray()
    {
        nnn = int.Parse(n.text);
        array = new Vector3[nnn];

        for (int i = 0; i < nnn; ++i)
        {
            random = UnityEngine.Random.Range(0, 5);
            array[i] = new Vector3(random, random + 1, random - 1);
        }
    }

}
