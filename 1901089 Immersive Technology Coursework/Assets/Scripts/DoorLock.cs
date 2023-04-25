using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{

    [SerializeField] GameObject door;
    [SerializeField] GameObject key;
    [SerializeField] GameObject handle;

    private bool DoorLocked;

    private void Awake()
    {
        if (door == null)
            Debug.LogError("No door gameobject set");

        if (handle == null)
            Debug.LogError("No handle gameobject set");
    }

    // Start is called before the first frame update
    void Start()
    {
        DoorLocked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "key" && DoorLocked)
        {
            if (other.gameObject == key)
                DoorUnlock();
            else
                UIManager.Instance.PlayerMessageUI.ShowPlayerMessage("This key doesn't fit this lock");
        }
    }

    private void DoorUnlock()
    {
        Rigidbody doorRb = door.GetComponent<Rigidbody>();
        if (doorRb != null)
            doorRb.isKinematic = false;
        else
            Debug.LogError("Door object has no Rigidbody component");

        BoxCollider handleCollider = handle.GetComponent<BoxCollider>();
        if (handleCollider != null)
            handleCollider.enabled = true;
        else
            Debug.LogError("Handle has no BoxCollider component");

        Rigidbody lockRb = GetComponent<Rigidbody>();
        if (lockRb != null)
        {
            lockRb.isKinematic = false;
            DoorLocked = false;
        }
        else
            Debug.LogError("Door lock has no Rigidbody component");

        AudioManager.Instance.PlayPickup();
    }
}
