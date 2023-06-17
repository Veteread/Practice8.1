using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

public class Moving : MonoBehaviour
{
    public bool forward;
    private float[] transfArray = { 1, 1, 0, 2, 2, 0, 3, 3, 0, 4, 4, 0 };
    public Object men1;
    public Transform point1;
    public Transform point2;
    private Vector3 target;
    public float speed;
    void Start()
    {
        target = point1.position;
    }

       void Update()
    {
        transform.LookAt(target);
        if (forward) 
            transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target)
        {
            if (target == point1.position)
                target = point2.position;
        else if (target == point2.position)
                target = point1.position;
        }
    }
    private void MoveMen()
    {
        transform.position = Vector3.zero;
        
    }
}
