using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class pauseGame : MonoBehaviour {

	// Use this for initialization
	public GameObject pauseUI;
	public GameObject pauseButtonUI; //pauses
	public GameManagerr joyIt;
	public bool paused;



	void Start () {

		paused = false;

	
	}

	void Update () {



	}

	// Update is called once per frame
	public void Pause () {


		paused = !paused;



		if (paused) {
			Time.timeScale = 0;
			joyIt.DisableJoy ();


		} 

		else if (!paused) 
		{
			Time.timeScale = 1;
			joyIt.EnableJoy ();
		}

		pauseUI.SetActive (true);
		pauseButtonUI.SetActive (false);


		}


	public void UnPause () {

		Pause ();


		pauseUI.SetActive (false);
		pauseButtonUI.SetActive (true);



	}
}
