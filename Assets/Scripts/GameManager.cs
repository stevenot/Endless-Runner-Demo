using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public GameObject tryAgainUI;
    private int mainMenu = 0;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            tryAgainUI.SetActive(true);
        }        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(mainMenu);
    }

}
