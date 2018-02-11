using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public GameObject prompt;
    public GameObject Inventory;
    public Canvas canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void displayText(string text)
    {
        prompt.GetComponent<TextPrompt>().setText(text);
    }

    public Canvas getCanvas()
    {
        return this.canvas;
    }

}
