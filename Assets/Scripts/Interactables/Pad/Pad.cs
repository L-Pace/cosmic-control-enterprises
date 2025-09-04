using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pad : MonoBehaviour
{
    [SerializeField]
    private GameObject padObj;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject scanner;

    
    public AudioSource buttonActivated;

    // Update is called once per frame
    void Update()
    {
        if (padObj.activeInHierarchy)
        {
            player.GetComponent<InputManager>().enabled = false;
            //playerUI.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void PlaySound()
    {
        buttonActivated.Play();
    }

    public void ActivateScanner()
    {
        scanner.GetComponent<MeshCollider>().enabled = true;
    }

    public void Exit()
    {
        player.GetComponent<InputManager>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        padObj.SetActive(false);
    }
}
