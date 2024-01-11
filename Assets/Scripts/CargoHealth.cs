using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargoHealth : MonoBehaviour
{
    [SerializeField] private float cargoHealth = 100;
    [SerializeField] private Image cargoUI;
    // Start is called before the first frame update
    void Start()
    {
        cargoHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        CargoHealthBar();
        //temp
        if (Input.GetKeyUp(KeyCode.E))
        {
            TakeDamage();
        }
    }

    void CargoHealthBar()
    {
        cargoUI.fillAmount = cargoHealth / 100f;
    }

    void TakeDamage()
    {
        //temp
        cargoHealth -= 20f;
    }
}
