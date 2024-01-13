using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RcktBase : MonoBehaviour
{
    public bool isLanded = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Celestial")
        {
            Debug.Log("Landed");
            isLanded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("left");
        isLanded = false;
    }
}
