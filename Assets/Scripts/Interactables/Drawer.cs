using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : Interactable
{
    [SerializeField]
    private GameObject drawer;

    [SerializeField]
    private GameObject pad;

    private bool isOpen;

    public AudioSource drawerSound;

    private void Start()
    {
        
    }

    protected override void Interact()
    {
        ToggleDrawer();

    }

    private void ToggleDrawer()
    {
        isOpen = !isOpen;
        drawer.GetComponent<Animator>().SetBool("isOpen", isOpen);
        drawer.GetComponentInChildren<MeshCollider>().enabled = false;
        pad.GetComponent<MeshCollider>().enabled = true;
    }

    public void PlaySound()
    {
        drawerSound.Play();
    }
}
