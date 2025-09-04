using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadInteractable : Interactable
{
    [SerializeField]
    private GameObject padObj;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<MeshCollider>().enabled = false;
        padObj.SetActive(false);
    }

    protected override void Interact()
    {
        padObj.SetActive(true);
    }
}
