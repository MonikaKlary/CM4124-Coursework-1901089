using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMessageUI : MonoBehaviour
{
    public TMP_Text TextBox;
    public CanvasGroup CanvasGroup;

    public void Awake()
    {

        ShowPlayerMessage("You've escaped your cell, now escape the rest of the Witch's Dungeon by finding the 4 runes for the magical lock");
    }

    public void ShowPlayerMessage(string inMessage)
    {
        TextBox.text = inMessage;

     
        StopAllCoroutines();
        CanvasGroup.alpha = 0;

        StartCoroutine(ShowForXSeconds(5f));
    }

    IEnumerator ShowForXSeconds( float duration )
    {
        CanvasGroup.alpha = 1;

        float elapsedTime = 0f;
        while ( elapsedTime < duration )
        {
            elapsedTime += Time.deltaTime;
            CanvasGroup.alpha = 1 - ( elapsedTime / duration );
            yield return null;
        }

        CanvasGroup.alpha = 0;
    }
}
