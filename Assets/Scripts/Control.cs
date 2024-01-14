using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Play()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LVL1()
    {
        StartCoroutine(WaitFunctionLv1());
        
    }
    public void LVL2()
    {
        StartCoroutine(WaitFunctionLv2());
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator WaitFunctionLv1()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level1");
    }

    IEnumerator WaitFunctionLv2()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Level2");
    }
}
