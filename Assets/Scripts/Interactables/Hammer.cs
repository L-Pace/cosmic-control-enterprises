using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : Interactable
{
    [SerializeField]
    private GameObject hammerHandle;

    [SerializeField]
    private GameObject hammerOnPlayer;

    [SerializeField]
    private GameObject hammer;

    public AudioSource hammerPickUpSound;

    // Start is called before the first frame update
    void Start()
    {
        hammerHandle.GetComponent<MeshCollider>().enabled = false;
    }

    protected override void Interact()
    {
        hammerOnPlayer.SetActive(true);
        hammer.SetActive(false);
    }

    public void PlaySound()
    {
        hammerPickUpSound.Play();
    }
}
