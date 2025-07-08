using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractuarConE : MonoBehaviour
{
    public GameObject interactionMsg;
    public mercancia mercancia;

    bool onInteraction = false;
    GameObject gameObjectOfInteraction;

    private void Start()
    {
        interactionMsg.SetActive(false);
    }

    private void Update()
    {

        interactionMsg.SetActive(onInteraction);
        if (onInteraction && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObjectOfInteraction);
            stopInteraction();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        bool isInteractable = other.GetComponent<mercancia>();
        if (isInteractable)
        {
            onInteraction = true;
            gameObjectOfInteraction = other.gameObject;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        stopInteraction();
    }

    void stopInteraction()
    {
        onInteraction = false;
        gameObjectOfInteraction = null;
    }
}
