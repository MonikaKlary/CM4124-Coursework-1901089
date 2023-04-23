using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Slider MusicVolumeSlider;
    public Slider BrightnessSlider;
    public TMP_Dropdown MovementTypeDropdown;
    public TMP_Dropdown RotationTypeDropdown;

    private void Awake()
    {
        OnVolumeChanged();
    }

    public void OnVolumeChanged()
    {
        AudioManager.Instance.SetAudioVolumes(MusicVolumeSlider.value);
    }

    public void OnBrightnessChanged()
    {
        GraphicsManager.Instance.SetBrightness(BrightnessSlider.value);
    }

    public void OnMovementTypeChanged()
    {
        string text = MovementTypeDropdown.options[MovementTypeDropdown.value].text;
        ControlsManager.EMovementType movementType = (ControlsManager.EMovementType)System.Enum.Parse(typeof(ControlsManager.EMovementType), text);

        ControlsManager.Instance.SetMovementType(movementType);
    }

    public void OnRotationTypeChanged()
    {
        string text = RotationTypeDropdown.options[RotationTypeDropdown.value].text;
        ControlsManager.ERotationType rotationType = (ControlsManager.ERotationType)System.Enum.Parse(typeof(ControlsManager.ERotationType), text);

        ControlsManager.Instance.SetRotationType(rotationType);
    }
}
