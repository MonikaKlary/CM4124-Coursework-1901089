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

    public static ControlsManager Instance { get; private set; }

    public EMovementType CurrentMovementType { get; private set; }
    public ERotationType CurrentRotationType { get; private set; }

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

    public void SetMovementType(EMovementType movementType)
    {
        CurrentMovementType = movementType;
    }

    public void SetRotationType(ERotationType rotationType)
    {
        CurrentRotationType = rotationType;
    }
}
