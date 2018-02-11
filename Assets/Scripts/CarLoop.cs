using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLoop : MonoBehaviour {

	public float movSpd = 10f;
	private Vector3 startLoc;

	void Start(){
		startLoc = transform.position+ new Vector3(0f,0f,500f);

	}
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector3.right * Time.deltaTime * movSpd);
		if (transform.position.z > startLoc.z) {
			transform.position = startLoc-new Vector3(0f,0f,500f);

		}

	}
}
