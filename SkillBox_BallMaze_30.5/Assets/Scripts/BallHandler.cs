using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallHandler : MonoBehaviour
{
    public static Action OnUILvlCompleted;
    public static Action OnUILvlFailed;

    private void Update()
    {
        ChecingTime();
    }

    private void ChecingTime()
    {
        if(Timer.timeLeft == 0)
        {
            OnUILvlFailed();
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "TriggerStart")
        {
            Timer.timeOn = true;
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TriggerFinish" && Timer.timeLeft >= 0)
        {
            Timer.timeOn = false;
            OnUILvlCompleted();
        }
    }
}
