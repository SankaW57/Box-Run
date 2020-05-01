using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour {

	//public string homeLevel = "MenuUI";
	// Use this for initialization
	public void HomeTriggered () {


		SceneManager.LoadScene("zN3k/Scenes/Menu8");
        SaveManager.Instance.Save();
	}

}
