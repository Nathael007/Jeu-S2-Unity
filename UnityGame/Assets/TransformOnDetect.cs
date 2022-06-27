using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformOnDetect : MonoBehaviour
{
    [SerializeField]
    GameObject player; float smoothTime = 0.8f; bool isOpened = false;
    [SerializeField]
    GameObject door;

    float velocity;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x >= -18 && player.transform.position.x <= -12 && player.transform.position.z <= -39 && player.transform.position.z >= -45)
        {
            transform.position = new Vector3(transform.position.x, Mathf.SmoothDamp(transform.position.y, 4f, ref velocity, smoothTime), transform.position.z);
            door.SetActive(false);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, Mathf.SmoothDamp(transform.position.y, 0f, ref velocity, smoothTime), transform.position.z);
            door.SetActive(true);
        }
    }
}
