using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScreen : MonoBehaviour
{
    [SerializeField]
    private GameObject computerScreen;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject playerUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (computerScreen.activeInHierarchy)
        {
            player.GetComponent<InputManager>().enabled = false;
            playerUI.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Exit()
    {
        player.GetComponent<InputManager>().enabled = true;
        playerUI.SetActive(true);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
        computerScreen.SetActive(false);
    }
}
