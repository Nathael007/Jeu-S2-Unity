using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vigie : MonoBehaviour
{
    [SerializeField]
    public Vector3 currentRotation; public Vector3 angleToRotate; public int dispersionX = 20; public int dispersionY = 20; public int dispersionZ = 20;

    Vector3 startAngles;

    float rnX, rnY, rnZ;

    void Start()
    {
        startAngles = currentRotation;

        rnX = startAngles.x;
        rnY = startAngles.y;
        rnZ = startAngles.z;

        currentRotation = new Vector3(currentRotation.x % 360f, currentRotation.y % 360f, currentRotation.z % 360f);
        transform.eulerAngles = currentRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentRotation.x < rnX || currentRotation.x > rnX + dispersionX)
        {
            angleToRotate.x = -angleToRotate.x;
            rnX = Random.Range(startAngles.x - dispersionX, startAngles.x - 0.25f * (float)dispersionX);
        }
        if (currentRotation.y < rnY || currentRotation.y > rnY + dispersionY)
        {
            angleToRotate.y = -angleToRotate.y;
            rnY = Random.Range(startAngles.y - dispersionY, startAngles.y - 0.25f * (float)dispersionY);
        }
        if (currentRotation.z < rnZ || currentRotation.z > rnZ + dispersionZ)
        {
            angleToRotate.z = -angleToRotate.z;
            rnZ = Random.Range(startAngles.z - dispersionZ, startAngles.z - 0.25f * (float)dispersionZ);
        }


        currentRotation += angleToRotate * Time.deltaTime;
        transform.eulerAngles = currentRotation;

    }
}