using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesInteractable : Interactable
{
    [SerializeField]
    private GameObject pipeOB;

    // Start is called before the first frame update
    void Start()
    {
        pipeOB.SetActive(false);
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    protected override void Interact()
    {
        pipeOB.SetActive(true);
    }

}
