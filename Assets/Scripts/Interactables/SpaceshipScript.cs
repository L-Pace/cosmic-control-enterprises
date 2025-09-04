using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    [SerializeField]
    private GameObject winScreen;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject timer;


    void Update()
    {
        if (winScreen.activeInHierarchy)
        {
            timer.GetComponentInChildren<Timer>().enabled = false;
            player.GetComponent<InputManager>().enabled = false;
            //playerUI.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(("Finish")))
        {
            winScreen.SetActive(true);

        }
    }
}

