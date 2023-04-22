using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsManager : MonoBehaviour
{
    private static GraphicsManager instance;
    public static GraphicsManager Instance
    {
        get
        {
            if (instance == null)
                Debug.LogError("No GraphicsManager in scene");

            return instance;
        }
        private set
        {
            instance = value;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Debug.LogWarning("GraphicsManager already exists in scene, destroying this extra instance");
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
