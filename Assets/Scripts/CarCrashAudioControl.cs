using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCrashAudioControl : MonoBehaviour {

	public AudioSource m_AudioSource;
	public float timer;

	private bool hasPlayed = false;

	// Update is called once per frame
	void FixedUpdate ()
	{
		if (timer <= 0 && hasPlayed == false) {
			hasPlayed = true;
			PlayAudio();

		}
		timer -= Time.deltaTime;
	}

	void PlayAudio ()
	{
		m_AudioSource.Play();
		
	}
}
