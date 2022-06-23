using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowing : MonoBehaviour
{
    private GameObject player;
    private float constX;
    private float constY;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("ThirdPersonController");
        constX = Camera.main.transform.position.x - player.transform.position.x;
        constY = Camera.main.transform.position.y - player.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = new Vector3(player.transform.position.x + constX, player.transform.position.y + constY, player.transform.position.z);
    }
}
