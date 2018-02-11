using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicEnvironmentController : MonoBehaviour {
	public Transform target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		target.transform.Rotate(0,100*Time.deltaTime,0);

	}
}
