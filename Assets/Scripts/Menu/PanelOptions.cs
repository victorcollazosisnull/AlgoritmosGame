using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelOptions : MonoBehaviour
{
    [Header("Movimiento del Panel de Opciones")]
    public RectTransform optionsPanel;
    public Vector2 hiddenPosition = new Vector2(-2000f, 0f);
    public Vector2 visiblePosition = Vector2.zero;
    public float smoothTime = 0.3f;

    public Slider brightnessSlider;
    public Image filtroBrillo;

    private Vector2 velocity = Vector2.zero;
    private bool isOptionsVisible = false;
    void Start()
    {
        float savedBrillo = PlayerPrefs.GetFloat("Brillo", 0f);
        brightnessSlider.value = savedBrillo;
        SetBrightness(savedBrillo);
        brightnessSlider.onValueChanged.AddListener(SetBrightness);
        optionsPanel.anchoredPosition = hiddenPosition;
    }
    void Update()
    {
        Vector2 targetPosition = isOptionsVisible ? visiblePosition : hiddenPosition;
        optionsPanel.anchoredPosition = Vector2.SmoothDamp(optionsPanel.anchoredPosition, targetPosition, ref velocity, smoothTime, Mathf.Infinity, Time.unscaledDeltaTime);
    }
    public void ShowPanelOptions()
    {
        isOptionsVisible = !isOptionsVisible;
    }
    private void SetBrightness(float brillo)
    {
        Color color = filtroBrillo.color;
        color.a = 1f - brillo;
        filtroBrillo.color = color;

        PlayerPrefs.SetFloat("Brillo", brillo);
        PlayerPrefs.Save();
    }
}
