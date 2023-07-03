using UnityEngine;
using CommonMethodsLibrary;
using TMPro;

public class UIShowCurrentSceneName : MonoBehaviour
{
    void Start()
    {
        GetComponent<TMP_Text>().text = DanUtils.MakeReturnSceneName();        
    }
}