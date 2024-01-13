using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2GameMngr : MonoBehaviour
{
    Dialog dialogScript;
    RcktBase baseScript;
    public GameObject Checkpoint;
    public GameObject LevelClear;
    

    void Start()
    {
        dialogScript = GameObject.Find("DialogBox").GetComponent<Dialog>();
        baseScript = GameObject.Find("Base").GetComponent<RcktBase>();
    }
    void Update()
    {
        if (dialogScript.index == 4 || Input.GetKeyDown(KeyCode.Escape))
        {
            Checkpoint.SetActive(true);
        }
        if (Checkpoint == null && baseScript.isLanded)
        {
            LevelClear.SetActive(true);
        }
    }
}
