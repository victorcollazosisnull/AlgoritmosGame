using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCredits : MonoBehaviour
{
    [Header("Movimiento del Panel de Opciones")]
    public RectTransform optionsPanel;
    public Vector2 hiddenPosition = new Vector2(-2000f, 0f);
    public Vector2 visiblePosition = Vector2.zero;
    public float smoothTime = 0.3f;


    private Vector2 velocity = Vector2.zero;
    private bool isCreditsVisible = false;
    void Start()
    {
        optionsPanel.anchoredPosition = hiddenPosition;
    }
    void Update()
    {
        Vector2 targetPosition = isCreditsVisible ? visiblePosition : hiddenPosition;
        optionsPanel.anchoredPosition = Vector2.SmoothDamp(optionsPanel.anchoredPosition, targetPosition, ref velocity, smoothTime, Mathf.Infinity, Time.unscaledDeltaTime);
    }
    public void ShowPanelCredits()
    {
        isCreditsVisible = !isCreditsVisible;
    }
}
