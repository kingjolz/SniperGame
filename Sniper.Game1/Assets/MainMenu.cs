using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void PlayButton(string Level1)
    {
        SceneManager.LoadScene(Level1);
    }

    public void CreditsButton(string Credits)
    {
        SceneManager.LoadScene(Credits);
    }

    public void HowToPlayButton(string HowToPlay)
    {
        SceneManager.LoadScene(HowToPlay);
    }


    public void QuitButton()
    {
        Application.Quit();
    }

    public void Level1Button(string Level1)
    {
        SceneManager.LoadScene(Level1);
    }

    public void Level2Button(string Level2)
    {
        SceneManager.LoadScene(Level2);
    }

    public void Level3Button(string Level3)
    {
        SceneManager.LoadScene(Level3);
    }
}
