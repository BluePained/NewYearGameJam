using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePlanet : MonoBehaviour
{
    public float velocity = 0.1f;
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward*velocity, Space.Self);
    }
}
