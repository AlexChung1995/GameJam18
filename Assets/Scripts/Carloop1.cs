using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Carloop1 : MonoBehaviour {

	public float movSpd = 10f;
	private Vector3 startLoc;
	public CanvasGroup canvasGroup;

    // Update is called once per frame


    void FixedUpdate () {
		transform.Translate (Vector3.right * Time.deltaTime * movSpd);
	}

	void OnCollisionEnter(Collision collision){
      

		if (collision.collider.tag == "CrashBuilding") {
			StartCoroutine(DoFade());
		}



	}

    void Load()
    {
        SceneManager.LoadScene(2);
    }



	IEnumerator DoFade ()
	{
		while (canvasGroup.alpha < 1) {
			canvasGroup.alpha += Time.deltaTime/2;
			yield return null;
		}
		canvasGroup.interactable=false;
		Load();
		yield return null;
	}
}