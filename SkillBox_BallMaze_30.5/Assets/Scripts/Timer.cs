using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private static Timer instance;
    [SerializeField] private float _time;
    [SerializeField] private TextMeshProUGUI _timerText;

    private float _timeLeft = 0f;
    public static bool timeOn = false;

    private void Start()
    {
        instance = this;

        _timeLeft = _time;
        timeOn = false;
    }

    private void Update()
    {
        if (timeOn)
        {
            _timeLeft += Time.deltaTime;
            UpdateTimeeText();
        }
    }

    private void UpdateTimeeText()
    {
        if(_timeLeft < 0)
        {
            _timeLeft = 0;
        }

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        _timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
