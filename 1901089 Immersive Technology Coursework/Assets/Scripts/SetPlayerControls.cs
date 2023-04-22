using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPlayerControls : MonoBehaviour
{
    private void Awake()
    {
        var continuousMovement = GetComponent<ActionBasedContinuousMoveProvider>();
        if (continuousMovement == null)
            Debug.LogError("Player controller is missing ActionBasedContinuousMoveProvider");

        var teleportMovement = GetComponent<TeleportationProvider>();
        if (teleportMovement == null)
            Debug.LogError("Player controller is missing TeleportationProvider");

        var continuousRotation = GetComponent<ActionBasedContinuousTurnProvider>();
        if (continuousRotation == null)
            Debug.LogError("Player controller is missing ActionBasedContinuousTurnProvider");

        var snapRotation = GetComponent<ActionBasedSnapTurnProvider>();
        if (snapRotation == null)
            Debug.LogError("Player controller is missing ActionBasedSnapTurnProvider");

        continuousMovement.enabled = ControlsManager.Instance.CurrentMovementType == ControlsManager.EMovementType.Continuous;
        teleportMovement.enabled = ControlsManager.Instance.CurrentMovementType == ControlsManager.EMovementType.Teleport;

        continuousRotation.enabled = ControlsManager.Instance.CurrentRotationType == ControlsManager.ERotationType.Continuous;
        snapRotation.enabled = ControlsManager.Instance.CurrentRotationType == ControlsManager.ERotationType.Snap;
    }
}
