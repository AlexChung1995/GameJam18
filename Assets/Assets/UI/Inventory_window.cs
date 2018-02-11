using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_window : MonoBehaviour {

    public Player player;
    public Text text;

	private const int INV_WINDOW_ID = 0; 
	private Rect _invWindowRect = new Rect (0, 0, 0, 0);

	//Rect constants
	private float left_offset = 10; 
	private float y_offset = 10; 
	public float _invWindowHeight = 90; 
	public float _invWindowWidth = 150;

    private void Update()
    {
        this.text.text = player.getCurrent();
    }

}
