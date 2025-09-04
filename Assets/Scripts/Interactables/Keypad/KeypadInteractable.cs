using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadInteractable : Interactable
{
    [SerializeField]
    private GameObject keypadOB;


    // Start is called before the first frame update
    void Start()
    {
        keypadOB.SetActive(false);
    }

    protected override void Interact()
    {
        keypadOB.SetActive(true);
    }

}
