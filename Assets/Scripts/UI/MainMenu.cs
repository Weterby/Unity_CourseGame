using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private bool isScenePaused = false;
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject options;

    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    // Update is called once per frame
     public void QuitButton()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isScenePaused = false;
    }

    public void PauseGame()
    {
        isScenePaused = true;
        Time.timeScale = 0f;
        menu.SetActive(true);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && CanPause())
        {
            PauseGame();
        }
    }

    private bool CanPause()
    {
        if(SceneManager.GetActiveScene().name == "GameScene" && !isScenePaused)
        {
            return true;
        }
        return false;
    }
}
