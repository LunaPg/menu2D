using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateComponenent : MonoBehaviour {

   public  string [] names = new string [] { "Button", " Checkbox", " Slider", "Dropdown", "Toggle" };
 //   public enum  names { Button,  Checkbox,  Slider, Dropdown, Toggle };

    protected List<GameObject> component ;
	// Use this for initialization
	void Start () {
        //component.Add (new Button);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
