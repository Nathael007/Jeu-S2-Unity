using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRandom : MonoBehaviour
{
    [SerializeField]
    Vector3 startPosition; Vector3 maxDegree; float speed;

    float leRandX;
    float leRandY;
    float leRandZ;

    float x;
    float y;
    float z;

    // Start is called before the first frame update
    void Start()
    {
        leRandX = Random.Range(startPosition.x - maxDegree.x, startPosition.x + maxDegree.x);
    }

    // Update is called once per frame
    void Update()
    {
        if (startPosition.x >  maxDegree.x)
        transform.Rotate(startPosition.x * Time.deltaTime, startPosition.y * Time.deltaTime, startPosition.z * Time.deltaTime);
    }
}
