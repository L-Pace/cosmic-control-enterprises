using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject pipeHolder;

    public GameObject[] pipes;

    public bool pipesCorrectOrder = false;

    [SerializeField]
    private int totalPipes;

    [SerializeField]
    private int correctedPipes = 0;

    [SerializeField]
    private GameObject pipeGridOB;

    [SerializeField]
    private GameObject confirmButtonOB;

    [SerializeField]
    private GameObject engageButtonOB;

    [SerializeField]
    private GameObject player;

    public Button confirmButton;

    public Button engageButton;

    // Start is called before the first frame update
    void Start()
    {
        totalPipes = pipeHolder.transform.childCount;

        pipes = new GameObject[totalPipes];


        for(int i = 0; i < pipes.Length; i++)
        {
            pipes[i] = pipeHolder.transform.GetChild(i).gameObject;
        }
    }

    public void CorrectMove()
    {
        correctedPipes++;

        if(correctedPipes == totalPipes)
        {
            confirmButton.interactable = true;
            pipesCorrectOrder = true;
            Confirm();
        }
    }

    public void WrongMove()
    {
        correctedPipes--;
    }

    public void Confirm()
    {
        confirmButtonOB.GetComponent<Image>().color = Color.yellow;
        Engage();
    }

    public void Engage()
    {
        //engageButton.GetComponent<Image>().color = Color.yellow;
    }
}
