using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eclairage : MonoBehaviour
{
    // Start is called before the first frame update
    public bool allumer = false;
    int range = 50;
    Light lampe;
    // Start is called before the first frame update
    void Start()
    {
        lampe = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse0) && allumer == false)
        {
            lampe.intensity = 1;
            allumer = true;
        }
        else if (Input.GetKey(KeyCode.Mouse1) && allumer == true)
        {
            lampe.intensity = 0;
            allumer = false;
        }

        lampe.spotAngle = range;
        if (Input.GetKey(KeyCode.Mouse4))
        {
            range--;
        }
        else if (Input.GetKey(KeyCode.Mouse3))
        {
            range++;
        }
        //else if (Input.GetKey(KeyCode.A)&& allumer == true)
        //{
        //    lampe.intensity = 0;
        //    allumer = false;
        //}

    }
    //private void MouseWheelHandle(object sender, MouseWheelEventArgs e)
    //{
    //    // If the mouse wheel delta is positive, move the box up.
    //    if (e.Delta > 0)
    //    {
    //        lampe.range++;
    //    }

    //    // If the mouse wheel delta is negative, move the box down.
    //    if (e.Delta < 0)
    //    {
    //        lampe.range--;
    //    }
    //}
}
