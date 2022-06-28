using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfficheComposant : MonoBehaviour
{
    public GameObject composant;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (composant == null)
        {
            Destroy(this.gameObject);
        }
    }
}
