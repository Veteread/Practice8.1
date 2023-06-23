using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Race : MonoBehaviour
{
    public Object Men;
    public GameObject Stick;
    public GameObject MyStick;
    public float speed = 4;
    public Transform target;
    
       private void Update()
    {
        transform.LookAt(target);
        transform.position = Vector3.MoveTowards(transform.position, target.position, Time.deltaTime * speed);
        if (transform.position == target.position)
        {
            Men.GetComponent<Race>().enabled = true;
            Stick.SetActive(true);
            MyStick.SetActive(false);
            enabled = false;
        }
    }
}
