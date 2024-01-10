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
            if(Vector3.Distance(rocket.transform.position,planet.transform.position) - planet.transform.localScale.x < 1f)
            {
                float m1 = planet.GetComponent<Rigidbody2D>().mass;
                float m2 = rocket.GetComponent<Rigidbody2D>().mass;
                float r = Vector3.Distance(planet.transform.position, rocket.transform.position);
                float gravity = G * m1 * m2 / r / r;
                rocket.GetComponent<Rigidbody2D>().AddForce((planet.transform.position - rocket.transform.position).normalized * gravity);
            }
        }
    }

    void movement()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rocket.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * thrustForce);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rocket.GetComponent<Rigidbody2D>().AddRelativeForce(-Vector2.up * thrustForce);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rocket.GetComponent<Rigidbody2D>().AddTorque(0.01f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rocket.GetComponent<Rigidbody2D>().AddTorque(-0.01f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        G = 1f;
        Debug.Log("In trigger");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        G = 0f;
        Debug.Log("trigger Exit");
    }
}
