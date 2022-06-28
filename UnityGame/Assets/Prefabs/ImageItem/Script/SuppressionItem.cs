using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuppressionItem : MonoBehaviour
{
    private GameObject _player1;
    private GameObject _player2;
    // Start is called before the first frame update
    void Start()
    {
        _player1 = GameObject.FindGameObjectWithTag("TPSplayer");
        _player2 = GameObject.FindGameObjectWithTag("FPSplayer");

    }

    // Update is called once per frame  
    void Update()
    {
        float distance1 = Vector3.Distance(this.gameObject.transform.position, _player1.transform.position);
        float distance2 = Vector3.Distance(this.gameObject.transform.position, _player2.transform.position);

        if (distance1 <= 1.5 || distance2 <= 1.5 && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(this.gameObject);
        }
    }
}
