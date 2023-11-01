using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void ExitMenu()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
