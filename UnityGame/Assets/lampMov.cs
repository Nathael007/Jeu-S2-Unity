using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampMov : MonoBehaviour
{
    private float xStart, yStart, zStart;
    private float xStop, yStop, zStop;
    private float smoothTime = 0.5f;
    public float speed = 10;

    public Vector3 targetPosition;
    public Vector3 startPosition;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = new Vector3(xStart, yStart, zStart);
        targetPosition = new Vector3 (xStop, yStop, zStop);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.SmoothDamp(startPosition, targetPosition, ref velocity, smoothTime, speed);

        if ()
    }
}
