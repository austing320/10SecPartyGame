using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour

{
    public float timeRemaining = 10f;
    public Text timerText;

    void Start()
    {

    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.Ceil(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            GameManager.Instance.LoseGame();
        }
    }
}
