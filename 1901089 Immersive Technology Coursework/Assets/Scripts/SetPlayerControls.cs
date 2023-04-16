using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetPlayerControls : MonoBehaviour
{
    private void Awake()
    {
        var continuousMovement = GetComponent<ActionBasedContinuousMoveProvider>();
        var teleportMovement = GetComponent<TeleportationProvider>();

        var continuousRotation = GetComponent<ActionBasedContinuousTurnProvider>();
        var snapRotation = GetComponent<ActionBasedSnapTurnProvider>();

        continuousMovement.enabled = ControlsManager.Instance.CurrentMovementType == ControlsManager.EMovementType.Continuous;
        teleportMovement.enabled = ControlsManager.Instance.CurrentMovementType == ControlsManager.EMovementType.Teleport;

        continuousRotation.enabled = ControlsManager.Instance.CurrentRotationType == ControlsManager.ERotationType.Continuous;
        snapRotation.enabled = ControlsManager.Instance.CurrentRotationType == ControlsManager.ERotationType.Snap;
    }
}
