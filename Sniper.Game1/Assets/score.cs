using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    public int killQuota;
    int remainingKills;
    Text ScoreUI; 


	// Use this for initialization
	void Start () {
        remainingKills = killQuota;
        ScoreUI = GetComponent<Text>();
        ScoreUI.text = remainingKills.ToString(); 

	}

    public void RegisterKill ()
    {
        --remainingKills;
        ScoreUI.text = remainingKills.ToString();
        if ( remainingKills == 0)
        {
            FindObjectOfType<GameManager>().onWinner();

        }

    }

	
	
}
