using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScreenInteractable : Interactable
{
    [SerializeField]
    private GameObject computerScreen;

    [SerializeField]
    private GameObject computerScreenObj;

    // Start is called before the first frame update
    void Start()
    {
        computerScreenObj.SetActive(false);
        computerScreen.GetComponent<MeshCollider>().enabled = false;
    }

    protected override void Interact()
    {
        computerScreenObj.SetActive(true);
    }

}
