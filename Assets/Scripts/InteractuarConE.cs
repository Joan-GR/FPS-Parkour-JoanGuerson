using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractuarConE : MonoBehaviour

{
    public GameObject interactionMessage;
    public mercancia Mercancia;

    void Start()
    {
        interactionMessage.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Mercancia)
            {
                Destroy(Mercancia.gameObject);
                StopInteraction();
            }
        }
    }

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log(other.gameObject.name);
        Mercancia = other.GetComponent<mercancia>();
        if (Mercancia)
        {
            interactionMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

    void StopInteraction()
    {
        interactionMessage.SetActive(false);
        Mercancia = null;
    }
}
