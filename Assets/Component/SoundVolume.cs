using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class SoundVolume:MonoBehaviour {
    protected AudioSource soundMixer;
    protected Slider slider;
    // Use this for initialization
    void Start() {
        try {
             AudioSource soundMixer = GetComponent<AudioSource> ( );
            slider = GameObject.Find ("SoundMixer").GetComponent<Slider> ( );
            soundMixer.volume=slider.value;
            Debug.Log (soundMixer);
            slider.onValueChanged.AddListener (delegate { onVolumeChange ( ); });
        } catch(Exception e ) {
            Debug.Log ("You need an Audio Source !");
            print (e);
    }
}
	
	// Update is called once per frame
	void onVolumeChange () {
        soundMixer.volume=slider.value;
    }
}
