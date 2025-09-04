using UnityEngine;

public class Seal : Interactable
{
    [SerializeField]
    private GameObject seal;

    [SerializeField]
    private GameObject brokenSeal;

    [SerializeField]
    private GameObject hammer;

    [SerializeField]
    private GameObject pipePanel;

    [SerializeField]
    private GameObject brokenSeal1;
    [SerializeField]
    private GameObject brokenSeal2;
    [SerializeField]
    private GameObject brokenSeal3;
    [SerializeField]
    private GameObject brokenSeal4;

    public AudioSource sealBrokenSound;

    // Start is called before the first frame update
    void Start()
    {
        seal.GetComponent<BoxCollider>().enabled = true;
        brokenSeal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    protected override void Interact()
    {
        if (hammer.activeInHierarchy)
        {
            seal.GetComponent<BoxCollider>().enabled = false;
            brokenSeal.SetActive(true);
        }

        if (brokenSeal1.activeInHierarchy && brokenSeal2.activeInHierarchy && brokenSeal3.activeInHierarchy &&brokenSeal4.activeInHierarchy)
        {
            hammer.SetActive(false);
            pipePanel.GetComponentInChildren<BoxCollider>().enabled = true;
        }
    }

    public void PlaySound()
    {
        sealBrokenSound.Play();
    }
}
