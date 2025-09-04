using UnityEngine;
using UnityEngine.UI;

public class Pipes : MonoBehaviour
{
    [SerializeField]
    private GameObject pipesObj;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private GameObject pipes;

    [SerializeField]
    private GameManager gameManager;

    [SerializeField]
    private GameObject emergencyButtonConsole2;


    public Button confirmButton;

    public AudioSource confirmButtonSound;

    // Start is called before the first frame update
    void Start()
    {
        confirmButton.interactable = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (pipesObj.activeInHierarchy)
        {
            player.GetComponent<InputManager>().enabled = false;
            //playerUI.SetActive(false);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Exit()
    {
        if (gameManager.pipesCorrectOrder)
        {
            player.GetComponent<InputManager>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            pipesObj.SetActive(false);
            pipes.GetComponent<BoxCollider>().enabled = false;
            emergencyButtonConsole2.GetComponent<MeshCollider>().enabled = true;
        }
        else
        {
            player.GetComponent<InputManager>().enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            pipesObj.SetActive(false);
        }
    }

    public void PlaySound()
    {
        confirmButtonSound.Play();
    }
}
