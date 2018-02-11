using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroText : MonoBehaviour {
	public Text text;
	public GameObject canvas;
	// Use this for initialization
	void Start () {
		
		text.text = "Post-traumatic stress disorder (PTSD)\n \nis a mental health condition that's triggered by a terrifying event " +
					"— either experiencing it or witnessing it. Symptoms may include flashbacks, nightmares and severe anxiety, as well " +
					"as uncontrollable thoughts about the event.";
		StartCoroutine (Wait ());


	}
	IEnumerator Wait(){
		
		yield return new WaitForSeconds(10);
		SceneManager.LoadScene (1);

	}

	// Update is called once per frame
	void Update () {
		





	}
}
