using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastForward : MonoBehaviour {
	public RaycastHit hit; 
	// Update is called once per frame

	void Update () {
		float distance; 
		//Debug raycast in editor
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 30; 
		Debug.DrawRay (transform.position, forward, Color.green);

		if(Physics.Raycast(transform.position, (forward), out hit)){
			distance = hit.distance;
			print ("You are " + distance + " from " + hit.collider.gameObject.name);
		}
	}



	public RaycastHit get_hit(){
		return hit; 
	}

}
