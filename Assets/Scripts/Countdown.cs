using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    public Text timerText;
    public float levelTime = 120f;
    bool gameStarted = false;
    bool gameEnded = false;
	
	void Update () {
        if(gameStarted && !gameEnded)
            levelTime -= Time.deltaTime;

        if(levelTime < 0) {
            levelTime = 0;
            EndGame();
        }
        timerText.text = FormattedTime(levelTime);	
	}

    public void StartGame() {
        gameStarted = true;
    }

    void EndGame() {
        Debug.Log("The End");
        gameEnded = true;
    }

    string FormattedTime(float time) {
        return 
            (int)(time / 60)
             + ":"
             + (time % 60 < 10 ? "0" : "")
             + (int)(time % 60);
    }

}
