using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryUI : MonoBehaviour
{
    public void ReturnToFrontEnd()
    {
        Debug.Log("Loading FrontEnd");
        SceneManager.LoadScene("FrontEnd");
    }
}
