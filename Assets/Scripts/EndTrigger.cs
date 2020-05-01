using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {
    public GameManagerr gameManager;

   void OnTriggerEnter ()
    {
        gameManager.CompleteLevel();

    }
	
}


