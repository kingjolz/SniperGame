using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{

    public void BackButtons(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
    }



}