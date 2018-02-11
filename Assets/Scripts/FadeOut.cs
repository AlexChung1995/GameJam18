using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {

	public CanvasGroup cg;
	public GameObject go;
	// Update is called once per frame
	void FixedUpdate ()
	{
		cg.alpha -= Time.deltaTime / 2;
		if (cg.alpha == 0) {
			go.SetActive(false);
		}

	}
}
