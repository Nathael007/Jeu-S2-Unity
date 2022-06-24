using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lampMov : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;
    [SerializeField]
    private Vector3 vecteur;
    [SerializeField]
    int minRandom = 1, maxRandom = 5;

    int timer;
    Vector3 debut;
    void Start()
    {
        debut = transform.position;
        timer = UnityEngine.Random.Range(minRandom, maxRandom);
    }

    void Update()
    {
        transform.position += new Vector3(vecteur.x * Time.deltaTime * speed, vecteur.y * Time.deltaTime * speed, vecteur.z * Time.deltaTime * speed);
        if (Time.fixedTime%timer == 0)
        {
            transform.position = debut;
            timer = UnityEngine.Random.Range(minRandom,maxRandom);
        }
    }
}
