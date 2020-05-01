using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InitialStartUp : MonoBehaviour {
	public Canvas MenuTwo;
	public Canvas MainMenu;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void InitialPlay (){
		
		SceneManager.LoadScene("Levels 1-10/Level11");

	}

	public void RemoveMainMenu (){

		MainMenu.enabled = false;
		MenuTwo.gameObject.SetActive (true);
		Debug.Log ("pressed");
	}

	public void NextLevel (){

		SceneManager.LoadScene("Levels 1-10/Beginner1");
	}

}
