using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public UnityEngine.UI.Text score;
    public UnityEngine.UI.Text highscore;

	// Use this for initialization
	void Start () {

        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore.text = PlayerPrefs.GetInt("highscore").ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
