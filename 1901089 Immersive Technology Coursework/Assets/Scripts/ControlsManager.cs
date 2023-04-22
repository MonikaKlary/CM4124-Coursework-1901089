using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsManager : MonoBehaviour
{
    public enum EMovementType
    {
        Teleport,
        Continuous
    }

    public enum ERotationType
    {
        Snap,
        Continuous
    }

    private static ControlsManager instance;
    public static ControlsManager Instance
    {
        get
        {
            if (instance == null)
                Debug.LogError("No ControlsManager in scene");

            return instance;
        }
        private set
        {
            instance = value;
        }
    }

    public EMovementType CurrentMovementType { get; private set; }
    public ERotationType CurrentRotationType { get; private set; }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Debug.LogWarning("ControlsManager already exists in scene, destroying this extra instance");
            GameObject.Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetMovementType(EMovementType movementType)
    {
        CurrentMovementType = movementType;
    }

    public void SetRotationType(ERotationType rotationType)
    {
        CurrentRotationType = rotationType;
    }
}
