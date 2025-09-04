using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : Interactable
{
    [SerializeField]
    private GameObject lever;

    [SerializeField]
    private GameObject computerScreen;

    private bool isPress;

    public AudioSource computerScreenSound;

    private void Start()
    {
        lever.GetComponent<BoxCollider>().enabled = false;
    }

    protected override void Interact()
    {
        ToggleLever();
    }

    private void ToggleLever()
    {
        isPress = !isPress;
        lever.GetComponent<Animator>().SetBool("isPress", isPress);
        computerScreen.GetComponent<Animator>().SetBool("isLeverPushed", isPress);
        computerScreen.GetComponent<MeshCollider>().enabled = true;
        lever.GetComponent<BoxCollider>().enabled = false;
    }

    public void PlaySound()
    {
        computerScreenSound.Play();
    }
}
