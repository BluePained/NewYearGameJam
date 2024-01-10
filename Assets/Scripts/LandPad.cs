using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandPad : MonoBehaviour
{
    GameObject target;
    public float velocity = 20f;
    void Start()
    {
        target = GameObject.Find("ExoPlanet");
    }


    void FixedUpdate()
    {
        transform.RotateAround(target.transform.position, new Vector3(0, 0, -1), velocity);
    }
}
