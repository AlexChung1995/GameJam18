using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody player;
	public float movSpd = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			player.AddForce (0, 0, movSpd * Time.deltaTime, ForceMode.VelocityChange);
			Debug.Log("hi");
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			player.AddForce (0, 0, -movSpd * Time.deltaTime, ForceMode.VelocityChange);
			Debug.Log("hi");
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			player.AddForce (-movSpd * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			Debug.Log("hi");
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			player.AddForce (movSpd * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			Debug.Log("hi");
		}
	}
}
