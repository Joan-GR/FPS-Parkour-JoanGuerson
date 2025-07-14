using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractuarConE : MonoBehaviour

{
    public GameObject interactionMessage;
    public mercancia Mercancia;
    public MoneyManager moneyManager;

    void Start()
    {
        interactionMessage.SetActive(false);
        moneyManager = FindObjectOfType<MoneyManager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Mercancia)
            {
                moneyManager.UpdateMoney(-1);
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
