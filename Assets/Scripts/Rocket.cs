using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    GameObject[] celestials;
    GameObject rocket;

    public float G = 0f;
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
            if(Vector3.Distance(rocket.transform.position,planet.transform.position) - planet.transform.localScale.x < 0.01f)
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
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * thrustForce);
            transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = true;
        }
        else
            transform.GetChild(1).GetComponent<SpriteRenderer>().enabled = false;

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rocket.GetComponent<Rigidbody2D>().AddRelativeForce(-Vector2.up * thrustForce);
            transform.GetChild(2).GetComponent<SpriteRenderer>().enabled = true;
        }
        else
            transform.GetChild(2).GetComponent<SpriteRenderer>().enabled = false;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rocket.GetComponent<Rigidbody2D>().AddTorque(0.05f);
            transform.GetChild(3).GetComponent<SpriteRenderer>().enabled = true;
        }
        else
            transform.GetChild(3).GetComponent<SpriteRenderer>().enabled = false;

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rocket.GetComponent<Rigidbody2D>().AddTorque(-0.05f);
            transform.GetChild(4).GetComponent<SpriteRenderer>().enabled = true;
        }
        else
            transform.GetChild(4).GetComponent<SpriteRenderer>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        G = 1f;
        //Debug.Log("In trigger");
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.transform.name);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        G = 0f;
        //Debug.Log("trigger Exit");
    }
}
