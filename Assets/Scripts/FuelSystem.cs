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
    [SerializeField] private Image FuelUI;
    void Start()
    {
        fuelLevel = 100;
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseFuel();
    }

    void DecreaseFuel()
    {
        
        if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            fuelLevel -= fuelDecreaseRate * fuelDecreaseSafety;
        }

        FuelUI.fillAmount = fuelLevel / 100f;
    }

}
