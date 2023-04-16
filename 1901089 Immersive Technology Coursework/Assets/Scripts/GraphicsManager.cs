using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsManager : MonoBehaviour
{
    public static GraphicsManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            GameObject.Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetBrightness(float brightnessValue)
    {
        RenderSettings.ambientIntensity = brightnessValue;
    }
}
