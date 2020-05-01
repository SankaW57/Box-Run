using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatingCube : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (65, 65, 65)*Time.deltaTime);
	}
}
