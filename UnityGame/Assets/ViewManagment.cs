using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;

public class ViewManagment : MonoBehaviour
{
    //instanciation des controleurs et des scripts de triggers
    public ThirdPersonCharacter TPSplayer;
    public RigidbodyFirstPersonController FPSplayer;
    public TriggerTPS triggerTPS;
    public TriggerFPS triggerFPS;
    //instanciation de la liste de tous les éléments du jeu !
    private List<GameObject> elements = new List<GameObject>();
    //variables system traveling TPS
    private Vector3 offset = new Vector3(-9.207f, 8.489f, 4.3696f);
    private float smoothTime = 0.50f;
    private Vector3 velocity = Vector3.zero;
    private Transform target;
    //true = TPSView false = FPSView
    private bool isTPS;
    //offset transition FPT-TPS
    private Vector3 offsetTransition = new Vector3(0, 0, 3);
    private Vector3 offsetTransitionFPS = new Vector3(0, 2, 0);
    private Vector3 offsetTransitionTPS = new Vector3(0, 6, 0);
    // Start is called before the first frame update
    void Start()
    {
        FPSplayer.gameObject.SetActive(false);
        List<GameObject> Room1 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room1"));
        List<GameObject> Room2 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room2"));
        List<GameObject> Room3 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room3"));
        List<GameObject> Room4 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room4"));
        List<GameObject> Room5 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room5"));
        List<GameObject> Room6 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room6"));
        List<GameObject> Room7 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room7"));
        List<GameObject> Room8 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room8"));
        List<GameObject> Room9 = new List<GameObject>(GameObject.FindGameObjectsWithTag("Room9"));
        List<GameObject> HallWay = new List<GameObject>(GameObject.FindGameObjectsWithTag("HallWay1"));
        elements.AddRange(Room1);
        elements.AddRange(Room2);
        elements.AddRange(Room3);
        elements.AddRange(Room4);
        elements.AddRange(Room5);
        elements.AddRange(Room6);
        elements.AddRange(Room7);
        elements.AddRange(Room8);
        elements.AddRange(Room9);
        elements.AddRange(HallWay);
        Debug.Log("elements.count : " + elements.Count);
        isTPS = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTPS)
        {
            if (triggerTPS.tagEnter == "Room1")
            {
                if (triggerTPS.tagExit == "Room7" || triggerTPS.tagExit == "Room2" || triggerTPS.tagStay == "Room1")
                {
                    target = elements.Find(x => x.name == "Floor13").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "Room7")
            {
                if (triggerTPS.tagExit == "Room1" || triggerTPS.tagStay == "Room7")
                {
                    target = elements.Find(x => x.name == "Floor71").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "Room2")
            {
                if (triggerTPS.tagExit == "Room1" || triggerTPS.tagExit == "Room3" || triggerTPS.tagStay == "Room2")
                {
                    target = elements.Find(x => x.name == "Floor23").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "Room3")
            {
                if (triggerTPS.tagExit == "Room2" || triggerTPS.tagStay == "Room3")
                {
                    target = elements.Find(x => x.name == "Floor34").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "HallWay1")
            {
                if (triggerTPS.tagExit == "Room7")
                {
                    //FPSplayer.transform.SetPositionAndRotation((TPSplayer.transform.position - offsetTransition + offsetTransitionFPS), TPSplayer.transform.rotation);
                    FPSplayer.transform.SetPositionAndRotation(new Vector3(TPSplayer.transform.position.x, TPSplayer.transform.position.y + 2, TPSplayer.transform.position.z + 2), TPSplayer.transform.rotation);
                    TPSplayer.gameObject.SetActive(false);
                    FPSplayer.gameObject.SetActive(true);
                    TPSplayer.transform.position = new Vector3(1000, 1000, 1000);
                    Debug.Log("passe Ici");
                    //Camera.main.gameObject.SetActive(false);
                    isTPS = false;
                }
            }
            if (triggerTPS.tagEnter == "Room4")
            {
                if (triggerTPS.tagExit == "HallWay1")
                {
                    target = elements.Find(x => x.name == "Floor44").transform;
                    Camera.main.transform.position = target.position + offset;
                }
                if (triggerTPS.tagExit == "Room8" || triggerTPS.tagStay == "Room4")
                {
                    target = elements.Find(x => x.name == "Floor44").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "Room8")
            {
                if (triggerTPS.tagExit == "Room4" || triggerTPS.tagExit == "Room5" || triggerTPS.tagStay == "Room8")
                {
                    target = elements.Find(x => x.name == "Floor81").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "Room5")
            {
                if (triggerTPS.tagExit == "Room8" || triggerTPS.tagExit == "Room6" || triggerTPS.tagExit == "Room9" || triggerTPS.tagStay == "Room5" )
                {
                    target = elements.Find(x => x.name == "Floor55").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "Room6")
            {
                if (triggerTPS.tagExit == "Room5" || triggerTPS.tagExit == "Room9" || triggerTPS.tagStay == "Room6")
                {
                    target = elements.Find(x => x.name == "Floor64").transform;
                    reachTarget(target.position + offset);
                }
            }
            if (triggerTPS.tagEnter == "Room9")
            {
                if (triggerTPS.tagExit == "Room6" || triggerTPS.tagExit == "Room5" || triggerTPS.tagStay == "Room9")
                {
                    target = elements.Find(x => x.name == "Floor91").transform;
                    reachTarget(target.position + offset);
                }
            }

        }
        if (!isTPS)
        {
            if (triggerFPS.tagEnter == "Room7")
            {
                if (triggerFPS.tagExit == "HallWay1")
                {
                    //TPSplayer.transform.SetPositionAndRotation((FPSplayer.transform.position + offsetTransition + offsetTransitionTPS), FPSplayer.transform.rotation);
                    TPSplayer.transform.SetPositionAndRotation(new Vector3(FPSplayer.transform.position.x, FPSplayer.transform.position.y, FPSplayer.transform.position.z), FPSplayer.transform.rotation); FPSplayer.gameObject.SetActive(false);
                    TPSplayer.gameObject.SetActive(true);
                    FPSplayer.gameObject.SetActive(false);
                    //FPSplayer.transform.position = new Vector3(1000, 1000, 1000);
                    //Camera.main.gameObject.SetActive(true);
                    Debug.Log("HallWay1 => Room7");
                    isTPS = true;
                }
            }
            if (triggerFPS.tagEnter == "Room4")
            {
                if (triggerFPS.tagExit == "HallWay1")
                {
                    TPSplayer.transform.SetPositionAndRotation(new Vector3(FPSplayer.transform.position.x, FPSplayer.transform.position.y, FPSplayer.transform.position.z), FPSplayer.transform.rotation); FPSplayer.gameObject.SetActive(false);
                    TPSplayer.gameObject.SetActive(true);
                    FPSplayer.gameObject.SetActive(false);
                    //FPSplayer.transform.position = new Vector3(1000, 1000, 1000);
                    //Camera.main.gameObject.SetActive(true);
                    isTPS = true;
                    target = elements.Find(x => x.name == "Floor44").transform;
                    Camera.main.transform.position = target.position + offset;
                }
            }
        }
    }

    void reachTarget(Vector3 targetPosition)
    {
        Camera.main.transform.position = Vector3.SmoothDamp(Camera.main.transform.position, targetPosition, ref velocity, smoothTime);
    }
}
