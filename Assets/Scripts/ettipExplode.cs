using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ettipExplode : MonoBehaviour
{
    [SerializeField] private AudioSource DestroySound;
    [SerializeField] private GameObject Rocket;
    private void Update()
    {
        if (Rocket.gameObject == null)
        {
            DestroySound.enabled = true;
        }
        else
        {
            DestroySound.enabled = false;
        }
    }
}
