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
        SceneManager.LoadScene("Level1");
    }
    public void LVL2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
