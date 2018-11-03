using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor (typeof (CreateComponenent))]

public class InspectorTab:  Editor {

    protected int choice = 0;
    protected string [] names = new string [] { "Button", " Checkbox", " Slider", "Dropdown", "Toggle" };
    public override void OnInspectorGUI()  {
        base.OnInspectorGUI ( );
        CreateComponenent createCompoEditor = (CreateComponenent)target;
       choice = EditorGUILayout.Popup( choice, names);
    }

}
