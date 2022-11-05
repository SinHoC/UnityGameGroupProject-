using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    //public GameObject GameOverGO;
    public GameObject GameOverGO;
    public GameObject scoreUITextGO;



    public enum GameManagerState
    {
        Opening,
        GamePlay,
        GameOver,
    }

    GameManagerState GMState;

    // Start is called before the first frame update
    void Start()
    {
        GMState = GameManagerState.Opening;
    }

    void UpdateGameManagerState()
    {
        switch(GMState)
        {
            case GameManagerState.Opening:

                GameOverGO.SetActive(false);

                break;

            case GameManagerState.GamePlay:

                break;

            case GameManagerState.GameOver:

                GameOverGO.SetActive(true);


                break;
        }
    }

    public void SetGameManagerState(GameManagerState state)
    {
        GMState = state;
        UpdateGameManagerState();
    }
}
