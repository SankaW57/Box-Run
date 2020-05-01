using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	public void StartTheGame () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		//SceneManager.GetSceneByName ("Level01");
		
	}
}
