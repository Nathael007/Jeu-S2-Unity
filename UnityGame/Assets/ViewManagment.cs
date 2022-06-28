using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Characters.ThirdPerson;

public class ViewManagment : MonoBehaviour
{
    //instanciation des controleurs et des scripts de triggers
    public ThirdPersonCharacter TPSplayer;
    public FirstPersonController FPSplayer;
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
            if (triggerTPS.tagEnter == "Room7" || triggerFPS.tagEnter == "Room7")
            {
                if (triggerTPS.tagExit == "Room1" || triggerFPS.tagExit == "HallWay1" || triggerTPS.tagStay == "Room7")
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
        }
    }

    void reachTarget(Vector3 targetPosition)
    {
        Camera.main.transform.position = Vector3.SmoothDamp(Camera.main.transform.position, targetPosition, ref velocity, smoothTime);
    }
}
