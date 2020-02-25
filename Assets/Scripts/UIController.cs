using System.Collections;
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
        pauseButton.SetActive(false);
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
        Application.Quit();
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("Score", 0);
        scoresText.text = "0";
    }
}
