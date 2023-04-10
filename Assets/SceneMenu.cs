using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    
    
    
    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Victory()
    {
        SceneManager.LoadScene(3);
    }
}
