using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown_Finished : MonoBehaviour {

    public Text timerText;
    public float levelTime = 120f;
	
	void Update () {
        levelTime -= Time.deltaTime;
        if(levelTime < 0) {
            levelTime = 0;
            EndGame();
        }
        timerText.text = SecondsToFormattedString(levelTime);
    }

    void EndGame() {
        Debug.Log("End");
    }

    string SecondsToFormattedString(float seconds) {
        string timeFormatted = "";
        timeFormatted = 
            (int)(seconds / 60) 
            + ":" 
            + (seconds % 60 < 10 ? "0" : "" )
            + (int)(seconds % 60);
        return timeFormatted;
    }

}
