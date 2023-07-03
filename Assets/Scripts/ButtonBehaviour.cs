using CommonMethodsLibrary;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Tween _tween;
    Vector3 _defaultScale;

    private void Start()
    {
        _defaultScale = this.transform.localScale;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _tween = transform.MakeScaleAnimation(1.3f, .5f);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        _tween.Kill();

        transform.MakeScale(_defaultScale);
    }

    public void ChangeScene(string sceneName)
    {
       StartCoroutine(DanUtils.MakeChangeScene(sceneName));
    }

    public void ChangingColor()
    {
        if (MenuBehaviour.OnChangeColor != null)
        {
            Color color = MenuBehaviour.OnChangeColor.Invoke();
            
            this.GetComponent<Image>().color = color;
         }
    }
}
