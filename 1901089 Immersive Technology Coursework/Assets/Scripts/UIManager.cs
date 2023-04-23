using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                Debug.LogError("No UIManager in scene");

            return instance;
        }
        private set
        {
            instance = value;
        }
    }

    public GameObject VictoryUI;
    public PlayerMessageUI PlayerMessageUI;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Debug.LogWarning("UIManager already exists in scene, destroying this extra instance");
            GameObject.Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void ShowVictoryUI(bool show)
    {
        VictoryUI.SetActive(show);
    }
}
