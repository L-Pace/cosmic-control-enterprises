using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyButtonConsole2 : Interactable
{
    [SerializeField]
    private GameObject emergencyButtonConsole2;

    [SerializeField]
    private GameObject spaceship;

    private bool isButtonPressed;

    private bool spaceshipTakeoff;

    public AudioSource pressButtonSound;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        ToggleButton();
    }

    private void ToggleButton()
    {
        isButtonPressed = !isButtonPressed;
        spaceshipTakeoff = !spaceshipTakeoff;
        emergencyButtonConsole2.GetComponent<Animator>().SetBool("isPress", isButtonPressed);
        spaceship.GetComponent<Animator>().SetBool("takeOff", spaceshipTakeoff);
    }

    public void PlaySound()
    {
        pressButtonSound.Play();
    }
}
