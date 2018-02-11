using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {
	public CanvasGroup canvasGroup;
	// Use this for initialization
	void Start () {
		StartCoroutine(DoFade());
	}
	
	IEnumerator DoFade ()
	{
		
		while (canvasGroup.alpha > 0) {
			canvasGroup.alpha -= Time.deltaTime/2;
			yield return null;
		}
		canvasGroup.interactable=false;
		yield return null;
	}
}
