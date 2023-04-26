using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TwoPlayers : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level With 2 Balls");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
