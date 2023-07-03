using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MenuBehaviour))]
public class MenuEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MenuBehaviour behaviour = (MenuBehaviour)target;

        if (GUILayout.Button("New Color"))
        {
            behaviour.AddRandomColorToList();
        }
    }
}
