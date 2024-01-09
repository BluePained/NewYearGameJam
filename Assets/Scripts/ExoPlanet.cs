using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExoPlanet : MonoBehaviour
{
    Vector3 target;
    public float velocity = 1f;
    void Start()
    {
        target = GameObject.Find("HomePlanet").transform.position;
    }

    
    void Update()
    {
        transform.RotateAround(target, new Vector3(0,0,-1), velocity * Time.deltaTime);
    }
}
