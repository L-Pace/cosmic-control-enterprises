using UnityEngine;
using UnityEngine.EventSystems;

public class MovablePipes : MonoBehaviour, IPointerDownHandler
{
    private float[] rotations = { 0, 90, 180, 270 };

    public float[] correctRotation;

    private int possibleRotations = 0;

    [SerializeField]
    private bool isPlaced = false;

    [SerializeField]
    private GameManager gameManager;

    void Start()
    {
        possibleRotations = correctRotation.Length;

        int rand = Random.Range(0, rotations.Length);
        transform.eulerAngles = new Vector3(0, 0, rotations[rand]);

        if (possibleRotations > 1)
        {
            if (Mathf.Round(transform.eulerAngles.z) == correctRotation[0]
                || Mathf.Round(transform.eulerAngles.z) == correctRotation[1])
            {
                isPlaced = true;
                gameManager.CorrectMove();
            }
        }
        else
        {
            if (Mathf.Round(transform.eulerAngles.z) == correctRotation[0])
            {
                isPlaced = true;
                gameManager.CorrectMove();

            }
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        transform.Rotate(new Vector3(0, 0, 90));


        if (possibleRotations > 1)
        {
            if (Mathf.Round(transform.eulerAngles.z) == correctRotation[0]
                || Mathf.Round(transform.eulerAngles.z) == correctRotation[1]
                && isPlaced == false)
            {
                isPlaced = true;
                gameManager.CorrectMove();

            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.WrongMove();
            }
        }
        else
        {
            if (Mathf.Round(transform.eulerAngles.z) == correctRotation[0] && isPlaced == false)
            {
                isPlaced = true;
                gameManager.CorrectMove();
            }
            else if (isPlaced == true)
            {
                isPlaced = false;
                gameManager.WrongMove();
            }
        }
    }
}

