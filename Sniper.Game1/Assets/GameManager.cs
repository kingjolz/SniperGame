using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private string menuName = "MainMenu";
    public Text winnerText;
    public Text loserText;

    public void Awake()
    {
        winnerText.gameObject.SetActive(false);
        loserText.gameObject.SetActive(false);
    }

    public void onWinner()
    {
        winnerText.gameObject.SetActive(true);
        SceneManager.LoadScene(menuName);

    }

    public void onLoser()
    {
        loserText.gameObject.SetActive(true);
        SceneManager.LoadScene(menuName);
    }
  

}
