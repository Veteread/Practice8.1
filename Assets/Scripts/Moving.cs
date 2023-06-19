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
    private int nnn = 0;
    private int random;
    void Start()
    {
        target.Set(0, 4, 0);
        // target = point1.position;
    }

       void Update()
    {
        //if (n != null && stopRand == false)
        //{
        //    FillArray();
        //    stopRand = true;
        //}
        MoveMen();
        //transform.LookAt(target);
        //if (forward)
        //    transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        //if (transform.position == target)
        //{
        //    if (target == point1.position)
        //        target = point2.position;
        //    else if (target == point2.position)
        //        target = point1.position;
        //}
    }
    private void MoveMen()
    {
        transform.LookAt(target);
        if (forward)
          
                transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
           
        //if (transform.position == target)
        //{
        //    if (target == array[0])
        //        target = array[1];
        //    else if (target == array[1])
        //        target = array[0];
        //}
    }
    private void FillArray()
    {
        nnn = int.Parse(n.text);
        array = new Vector3[nnn];
        //array[0] = new Vector3(1f, 0f, 1f);
        //array[1] = new Vector3(2f, 2f, 2f);


        //for (int i = 0; i < nnn; ++i)
        //{
        //    random = UnityEngine.Random.Range(0, 5);
        //    array[i] = new Vector3(random, random, random);
        //    Debug.Log(random);
        //}
    }

}
