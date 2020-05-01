using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryScript : MonoBehaviour {

	// Use this for initialization
	GameManagerr gM;
	
	// Retry Button Script
	public void RetryAgain () {

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		gM = GetComponent<GameManagerr>();
		gM.moJay.enabled = true;
		Debug.Log ("pressed");
	}
}
