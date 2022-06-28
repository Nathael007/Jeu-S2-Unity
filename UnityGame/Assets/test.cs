using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;

public class test : MonoBehaviour
{
    public ThirdPersonCharacter TPSplayer;
    public RigidbodyFirstPersonController FPSplayer;
    // Start is called before the first frame update
    void Start()
    {
        TPSplayer.gameObject.SetActive(true);
        FPSplayer.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
        {
            FPSplayer.gameObject.SetActive(true);
            TPSplayer.gameObject.SetActive(false);
        }
    }
}
