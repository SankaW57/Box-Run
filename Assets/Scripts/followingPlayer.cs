using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset; //Stores 3 numbers (3 floats)

	// Update is called once per frame
	void Update () {
        transform.position = player.position + offset;
        
	}
}
