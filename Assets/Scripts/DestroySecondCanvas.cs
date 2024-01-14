using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySecondCanvas : MonoBehaviour
{
    [SerializeField] private GameObject[] secondCanvas;
    // Start is called before the first frame update
    void Start()
    {
        secondCanvas = GameObject.FindGameObjectsWithTag("SecondCanvas");
    }

    // Update is called once per frame
    void Update()
    {
        if(secondCanvas.Length >=2)
        {
            Destroy(this.gameObject);
        }
    }
}
