using TMPro;
using UnityEngine;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI textMeshPro;
    void Update()
    {
        float TempText = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        textMeshPro.text = TempText.ToString();
    }
}

