using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : MonoBehaviour {

    public string name;
    public float resolutionVal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string getName()
    {
        return this.name;
    }

    public float getRelVal()
    {
        return this.resolutionVal;
    }

}
