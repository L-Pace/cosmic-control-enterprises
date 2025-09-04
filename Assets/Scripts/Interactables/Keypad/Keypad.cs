using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    public TextMeshProUGUI textOb;

    public string answer = "1412";

    private bool isOpen;


    [SerializeField]
    private GameObject keypadOB;

    [SerializeField]
    private GameObject keypad;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject safeDoor;

    [SerializeField]
    private GameObject hammerHandle;

    public AudioSource keypadSound;

    public bool isTheCodeValid = false;

    void Update()
    {
        if (keypadOB.activeInHierarchy)
        {
            player.GetComponent<InputManager>().enabled = false;
            //playerUI.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }


    public void PlaySound()
    {
        keypadSound.Play();
    }

    public void Number(int number)
    {
        textOb.text += number.ToString();
    }

    public void Execute()
    {
        if (textOb.text == answer)
        {
            textOb.text = "Valid";
            isTheCodeValid = true;
        }
        else
        {
            textOb.text = "Invalid";
            isTheCodeValid = false;
        }
    }

    public void Clear()
    {
        textOb.text = "";
    }

    public void Exit()
    {
        if (!isTheCodeValid)
        {
            player.GetComponent<InputManager>().enabled = true;
            //playerUI.SetActive(true);
            Cursor.visible = false;
            textOb.text = "";
            keypadOB.SetActive(false);
        }
        else
        {
            player.GetComponent<InputManager>().enabled = true;
            //playerUI.SetActive(false);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            keypadOB.SetActive(false);
            StartSafeDoorAnimation();
            hammerHandle.GetComponent<MeshCollider>().enabled = true;
            //endScreenScript.ShowEndScreen();
        }
    }

    private void StartSafeDoorAnimation()
    {
        isOpen = !isOpen;
        safeDoor.GetComponent<Animator>().SetBool("isOpen", isOpen);
        keypad.GetComponent<MeshCollider>().enabled = false;
    }
}
