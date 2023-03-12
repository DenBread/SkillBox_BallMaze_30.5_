using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private static Timer instance;
    [SerializeField] private float _time;
    [SerializeField] private TextMeshProUGUI _timerText;

    public static float timeLeft = 0f;
    public static bool timeOn = false;

    private void Start()
    {
        instance = this;

        timeLeft = _time;
        UpdateTimeeText();
        timeOn = false;
    }

    private void Update()
    {
        if (timeOn)
        {
            if(timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                UpdateTimeeText();
            }
            else
            {
                timeLeft = _time;
                timeOn = false;
            }
        }
    }

    private void UpdateTimeeText()
    {
        if(timeLeft < 0)
        {
            timeLeft = 0;
        }

        float minutes = Mathf.FloorToInt(timeLeft / 60);
        float seconds = Mathf.FloorToInt(timeLeft % 60);
        _timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
