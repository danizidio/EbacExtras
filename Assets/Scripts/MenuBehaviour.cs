using System.Collections.Generic;
using UnityEngine;
using CommonMethodsLibrary;
using System;

public class MenuBehaviour : MonoBehaviour
{
    public static Func<Color> OnChangeColor;

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

    private void OnEnable()
    {
        OnChangeColor = ChangeColor;
    }
}
