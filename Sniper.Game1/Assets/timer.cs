using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class timer : MonoBehaviour {
    
   public float finishTime;
   float remainingTime;
   Text TimerUI;

    string TimeConvertToText()
    {
        int roundedTime = Mathf.RoundToInt(remainingTime);
        return string.Format("{0:D1}:{1:D2}", roundedTime / 60, roundedTime % 60);
    }

    // Use this for initialization
    void Start ()
    {
        remainingTime = finishTime;
        TimerUI = GetComponent<Text>();
        TimerUI.text = TimeConvertToText();
    }

    public void Update ()
    {
        remainingTime -= Time.deltaTime;
        TimerUI.text = TimeConvertToText();
        if (remainingTime <= 0)
        {
            FindObjectOfType<GameManager>().onLoser();

        }

    }
}
