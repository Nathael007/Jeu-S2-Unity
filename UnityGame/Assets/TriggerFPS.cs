using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFPS : MonoBehaviour
{
    public string tagEnter;
    public string nameEnter;
    public string tagExit;
    public string nameExit;
    public string tagStay;
    public string nameStay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        tagEnter = other.tag;
        nameEnter = other.name;
    }

    public void OnTriggerExit(Collider other)
    {
        tagExit = other.tag;
        nameExit = other.name;
    }

    public void OnTriggerStay(Collider other)
    {
        tagStay = other.tag;
        nameStay = other.name;
    }
}
