using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class ScoreScript : MonoBehaviour
{

    [SerializeField] private int score;
    [SerializeField] private int finalScore;
    [SerializeField] private UnityEvent winAction;

    private void Awake()
    {
        if (winAction == null)
            Debug.LogError("No winAction set");
    }

    public void UpdateScore()
    {
        score++;
        if(score == finalScore)
        {
            winAction.Invoke();
            AudioManager.Instance.PlayPickup();
        }
    }

    public void WinGame()
    {
        AudioManager.Instance.PlayWinSFX();
        UIManager.Instance.ShowVictoryUI(true);
    }
}
