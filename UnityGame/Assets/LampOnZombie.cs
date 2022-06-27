using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampOnZombie : MonoBehaviour
{
    bool isOn = false;
    [SerializeField]
    GameObject light;
    [SerializeField]
    GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        light.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOn && player.transform.position.x >= 0 && player.transform.position.x <= 6 && player.transform.position.y <= - 46.5f && player.transform.position.y >= 48)
        {
            light.SetActive(true);
        }
    }
}
