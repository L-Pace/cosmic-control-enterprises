using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PipesPanel : Interactable
{
    [SerializeField]
    private GameObject pipesPanelMovable;

    [SerializeField]
    private GameObject pipesInteractable;

    private bool areSealsBroken;

    public AudioSource movingThePanelSound;



    // Start is called before the first frame update
    void Start()
    {
        pipesPanelMovable.GetComponentInChildren<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        TogglePanel();
    }

    private void TogglePanel()
    {
        areSealsBroken = !areSealsBroken;
        pipesPanelMovable.GetComponent<Animator>().SetBool("areSealsBroken", areSealsBroken);
        pipesPanelMovable.GetComponent<BoxCollider>().enabled = true;
        pipesInteractable.GetComponent<BoxCollider>().enabled = true;
        pipesPanelMovable.GetComponent<BoxCollider>().enabled = false;

    }

    public void PlaySound()
    {
        movingThePanelSound.Play();
    }
}
