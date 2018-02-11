using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour {
	private Vector3 officePos;
	private Vector3 cityPos;
	private bool curLoc;
	public Transform target;
	public Player curPlayer;

	// Use this for initialization
	void Start () {
		cityPos = target.position;
		curLoc = true; // player is in office
		curPlayer.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown (KeyCode.R) && curLoc == true) {
			officePos = transform.position;
			transform.position = cityPos;
			curLoc = false; 
			curPlayer.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
			curPlayer.GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotation;


		} else if (Input.GetKeyDown (KeyCode.R) && curLoc == false) {
			curLoc = true; 
			cityPos = transform.position;
			transform.position = officePos;
			curPlayer.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
		}
	}

}
