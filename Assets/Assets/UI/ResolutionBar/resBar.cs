using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resBar : MonoBehaviour {

    public float rate;
    public Player player;
    public Image foreground;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(foreground.fillAmount);
        //Debug.Log(player.getRes());
        foreground.fillAmount += (player.getRes() / 100 - foreground.fillAmount)*rate/100;
	}

}
