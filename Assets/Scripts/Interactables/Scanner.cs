using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : Interactable
{
    [SerializeField]
    private GameObject scanner;

    [SerializeField]
    private GameObject button;

    private bool isScannerUsed;

    public AudioSource scannerSound;

    private void Start()
    {
        scanner.GetComponent<MeshCollider>().enabled = false;
    }

    public void PlaySound()
    {
        scannerSound.Play();
    }

    protected override void Interact()
    {
        ToggleScanner();
    }

    private void ToggleScanner()
    {
        isScannerUsed = !isScannerUsed;
        scanner.GetComponent<Animator>().SetBool("isUsed", isScannerUsed);
        scanner.GetComponent<MeshCollider>().enabled = false;
        button.GetComponent<MeshCollider>().enabled = true;
    }
}
