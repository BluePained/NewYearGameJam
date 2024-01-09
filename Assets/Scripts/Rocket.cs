using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    GameObject[] celestials;
    GameObject rocket;

    public float G = 10f;
    public float thrustForce = 10f;

    void Start()
    {
        celestials = GameObject.FindGameObjectsWithTag("Celestial");
        rocket = GameObject.FindGameObjectWithTag("Player");
    }

    
    void FixedUpdate()
    {
        Gravity();
        movement();
    }

    void Gravity()
    {
        foreach (GameObject planet in celestials)
        {
            float m1 = planet.GetComponent<Rigidbody2D>().mass;
            float m2 = rocket.GetComponent<Rigidbody2D>().mass;
            float r = Vector3.Distance(planet.transform.position, rocket.transform.position);
            float gravity = G * m1 * m2 / r / r;

            rocket.GetComponent<Rigidbody2D>().AddForce((planet.transform.position - rocket.transform.position).normalized * gravity);
        }
    }

    void movement()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rocket.GetComponent<Rigidbody2D>().AddForce(rocket.transform.up * thrustForce);
            Debug.Log("pressed"+ rocket.transform.up);
        }
    }
}
