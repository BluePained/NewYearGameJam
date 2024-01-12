using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RcktTip : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Celestial")
        {
            Debug.Log("Destroy");
            Destroy(transform.parent.gameObject);
        }
       
    }
}
