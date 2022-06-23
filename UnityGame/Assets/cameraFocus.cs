using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Salles { salle11, salle12, salle13, salle14, sallle15, salle16, salle17, salle19,
    salle21, salle22, salle23, salle24, salle25, salle26, salle27 };
public class cameraFocus : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 offset = new Vector3(-7f, 6.58f, 0);
    private float smoothTime = 0.50f;
    private Vector3 velocity = Vector3.zero;
    private Salles salle;
    [SerializeField] private Transform target;
    private GameObject player;
    void Start()
    {
        salle = Salles.salle12;
        player = GameObject.Find("ThirdPersonController");
        target = GameObject.Find("Salle12").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        Camera.main.transform.position = Vector3.SmoothDamp(Camera.main.transform.position, targetPosition, ref velocity, smoothTime);
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "salle1" && salle == Salles.salle22)
        {
            target = GameObject.Find("Salle22").transform;
        }
        if (other.gameObject.tag == "salle2" && salle == Salles.salle12)
        {
            target = GameObject.Find("Salle12").transform;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "salle1")
        {
            salle = Salles.salle12;
        }
        if (other.gameObject.tag == "salle2")
        {
            salle = Salles.salle22;
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "salle2")
        {
            if (other.gameObject.name == "Salle25" || other.gameObject.name == "Salle24" || other.gameObject.name == "Salle23")
                target = GameObject.Find("Salle25").transform;
            else
                target = GameObject.Find("Salle22").transform;
        }
    }
}
