using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Experimental.UIElements;

public class SoundVolume:MonoBehaviour {
    protected AudioSource soundMixer;
    protected Slider slider;
    // Use this for initialization
    void Start() {
        try {
             AudioSource soundMixer = GetComponent<AudioSource> ( );
            soundMixer.volume=slider.value;
            Debug.Log (soundMixer);
        } catch(Exception e ) {
            Debug.Log ("You need an Audio Source !");
            print (e);
    }
}
	
	// Update is called once per frame
	void Update () {
        soundMixer.volume=slider.value;
    }
}
