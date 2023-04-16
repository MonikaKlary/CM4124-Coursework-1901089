using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FreezeRotationOnAwake : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Rigidbody>().freezeRotation = true;
    }
}
