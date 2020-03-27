using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject pauseButton;
    [SerializeField] Text scoresText;
    public void PauseMenu()
    {
        menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Play()
    {
        Time.timeScale = 1;
        menu.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("Score", 0);
    }

    public void lvl_load()
    {
        SceneManager.LoadScene("Lvl_1");
        Time.timeScale = 1;
    }
}
