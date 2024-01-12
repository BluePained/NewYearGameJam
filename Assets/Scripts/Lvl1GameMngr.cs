using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1GameMngr : MonoBehaviour
{
    Dialog dialogScript;
    public GameObject Checkpoint;
    public GameObject LevelClear;
    

    void Start()
    {
        dialogScript = GameObject.Find("DialogBox").GetComponent<Dialog>();
    }
    void Update()
    {
        if (dialogScript.index == 4 || Input.GetKeyDown(KeyCode.Escape))
        {
            Checkpoint.SetActive(true);
        }
        if (Checkpoint == null)
        {
            LevelClear.SetActive(true);
        }
    }
}
