using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_wind_left : MonoBehaviour {


	private const int INV_WINDOW_ID = 0; 
	private Rect _invWindowRect = new Rect (0, 0, 0, 0);

	//Rect constants
	private float left_offset = 100; 
	private float y_offset = Screen.height - 10; 
	public float _invWindowHeight = 90; 
	public float _invWindowWidth = 150; 


	// Update is called once per frame

	void OnGUI(){
		_invWindowRect = GUI.Window(INV_WINDOW_ID, new Rect(left_offset, y_offset, _invWindowWidth, _invWindowHeight), InvWindow, "InvWindowleft");
	}

	private void InvWindow(int id){

	}
}