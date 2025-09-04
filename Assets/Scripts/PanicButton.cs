using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanicButton : Interactable
{
    protected override void Interact()
    {
        Application.Quit();
        Debug.Log("Game quit!!");
    }

}
