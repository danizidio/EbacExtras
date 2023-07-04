using CommonMethodsLibrary;
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

    [MenuItem("Módulo 23/GameObjectOnScene")]
    public static void CreateGameObject()
    {
        if(MenuBehaviour.OnCallObj != null)
        MenuBehaviour.OnCallObj?.Invoke();
        else MonoBehaviour.print("O botão irá criar o item desde que a cena esteja em 'PLAY MODE'");
    }
}
