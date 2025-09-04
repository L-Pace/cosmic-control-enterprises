using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timerText;

    [SerializeField]
    float remainingTime;

    [SerializeField]
    private GameObject gameOverScreen;

    // Update is called once per frame
    void Update()
    {
        int minutes;
        int seconds;


        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        if (remainingTime < 0)
        {
            remainingTime = 0;


            timerText.color = Color.red;

            gameOverScreen.SetActive(true);
        }

        minutes = Mathf.FloorToInt(remainingTime / 60);
        seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
