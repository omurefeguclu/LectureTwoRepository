using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CustomUI : MonoBehaviour
{
    public TextMeshProUGUI textToChange;
    public CanvasGroup canvasGroupToFade;
    public Button buttonToClick;
    public Image imageToMove;
    
    
    private void Awake()
    {
        //textToChange.text = "Bunu değiştirdim";
        
        
        buttonToClick.onClick.AddListener(OnButtonClicked);
    }

    private void OnButtonClicked()
    {
        Vector2 firstPosition = imageToMove.rectTransform.localPosition;
        firstPosition.x += 100;
        firstPosition.y += 100;

        imageToMove.rectTransform
            .DOLocalMove(firstPosition, 1f)
            .OnComplete(() =>
            {
                imageToMove.DOFade(0f, 1f);
                
            });
    }

    private void OnDestroy()
    {
        buttonToClick.onClick.RemoveListener(OnButtonClicked);
    }
}
