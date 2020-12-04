using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musik : MonoBehaviour {

	static Musik instance = null;
	public Slider SliderVolume;
	public AudioSource MusikBackground;

	private void Awake()	
	{
		if (instance != null) 
		{
			Destroy(gameObject);
		} else 
		{
			instance = this;
			GameObject.DontDestroyOnLoad (gameObject);
		}
	}

	public void ToggleSound()
	{
		if (PlayerPrefs.GetInt ("Muted", 0) == 0) {
			PlayerPrefs.SetInt ("Muted", 1);
		} else 
		{
			PlayerPrefs.SetInt ("Muted", 0);
		}
	}

	public void ChangeVolume(){
		MusikBackground.volume = SliderVolume.value;
	}
}
