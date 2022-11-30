using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //public GameObject scoreUITextGO;

    public void PlayGameLevel1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("button clicked");
    }

    public void PlayGameLevel2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log("button clicked");
    }

    public void PlayGameLevel3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        Debug.Log("button clicked");
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void RePlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene(0);
        playercontroll.score = 10;
    }

}
