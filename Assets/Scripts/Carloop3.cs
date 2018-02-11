using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carloop3 : MonoBehaviour {

	public float movSpd = 10f;
	private Vector3 startLoc;

	void Start(){
		
	}
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.right * Time.deltaTime * movSpd);


	}
}
