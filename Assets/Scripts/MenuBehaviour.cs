using System.Collections.Generic;
using UnityEngine;
using CommonMethodsLibrary;
using System;
using UnityEditor;

public class MenuBehaviour : MonoBehaviour
{
    [SerializeField] SO_GameObjects _gameObjects;

    public static Func<Color> OnChangeColor;

    public static Action OnCallObj;

    [SerializeField] List<Color> _colorList;

    public List<Color> colorList {get { return _colorList;}}

    public Color ChangeColor()
    {
       return DanUtils.MakeRandomItemList(_colorList);
    }

    public void AddRandomColorToList()
    {
        Color c = new Color32((byte)UnityEngine.Random.Range(0, 255),
            (byte)UnityEngine.Random.Range(0, 255),
            (byte)UnityEngine.Random.Range(0, 255), 255);

        _colorList.Add(c);
    }

    public void InstantiateObjects()
    {
        GameObject[] t = GameObject.FindGameObjectsWithTag("SPAWN");
        GameObject g = DanUtils.MakeRandomItemList(_gameObjects.gameObjects);
        Instantiate(g, DanUtils.MakeRandomItemArray(t).transform.position, Quaternion.identity);
    }


    private void OnEnable()
    {
        OnChangeColor = ChangeColor;
        OnCallObj = InstantiateObjects;
    }
}
