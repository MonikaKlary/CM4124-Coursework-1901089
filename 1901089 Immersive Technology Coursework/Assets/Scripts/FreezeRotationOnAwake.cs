using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FreezeRotationOnAwake : MonoBehaviour
{
    private void Awake()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
            rb.freezeRotation = true;
        else
            Debug.LogError("Cannot freeze rotation on awake for gameobject with no Rigidbody component");
    }
}
