using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyButton : Interactable
{
    [SerializeField]
    private GameObject button;
    [SerializeField]
    private GameObject topLeverContainer;

    [SerializeField]
    private GameObject lever;

    private bool isOpen;

    private bool isButtonPressed;

    public AudioSource buttonPressSound;

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
        isOpen = !isOpen;
        button.GetComponent<Animator>().SetBool("isPress", isButtonPressed);
        //button.GetComponent<Animator>().SetTrigger("isPress");
        topLeverContainer.GetComponent<Animator>().SetBool("isOpen", isOpen);
        lever.GetComponent<BoxCollider>().enabled = true;
        button.GetComponent<MeshCollider>().enabled = false;
    }

    public void PlaySound()
    {
        buttonPressSound.Play();
    }

}
