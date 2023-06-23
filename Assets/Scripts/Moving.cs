using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    public bool forward;
    private bool stopRand = false;
    public InputField n;
    private Vector3[] array;   
    private Vector3 target;
    public float speed;
    private int endN = 0;
    private int random, random2;
    private int beginN;
  
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
                else forward = true;
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
                else forward = false;
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
