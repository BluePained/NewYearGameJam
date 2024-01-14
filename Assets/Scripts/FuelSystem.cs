using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelSystem : MonoBehaviour
{
    [Header("Data")]
    [SerializeField] private float fuelLevel = 100;
    [SerializeField] private float fuelDecreaseRate;
    //Increase this will make fuel decrease faster
    [SerializeField] private float fuelDecreaseSafety;
    [Header("GameObject")]
    [SerializeField] private AudioSource RocketSound;
    [SerializeField] private Image FuelUI;
    void Start()
    {
        RocketSound.volume = 0;
        fuelLevel = 100;
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseFuel();
    }

    void DecreaseFuel()
    {
        
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            RocketSound.enabled = true;
            RocketSound.volume += 0.01f * 0.2f;
            RocketSound.volume = Mathf.Clamp(RocketSound.volume, 0f, 0.5f);
            fuelLevel -= fuelDecreaseRate * fuelDecreaseSafety;
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            RocketSound.enabled = true;
            RocketSound.volume += 0.01f * 0.2f;
            RocketSound.volume = Mathf.Clamp(RocketSound.volume, 0f, 0.35f);
        }
        else
        {
            RocketSound.volume -= 0.01f * 0.2f;
            if(RocketSound.volume <= 0.1f)
            RocketSound.enabled = false;
        }


        FuelUI.fillAmount = fuelLevel / 100f;
    }

}
