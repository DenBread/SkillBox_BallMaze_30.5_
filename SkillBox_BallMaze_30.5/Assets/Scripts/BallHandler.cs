using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallHandler : MonoBehaviour
{
    public static Action OnUILvlCompleted;

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "TriggerStart")
        {
            Timer.timeOn = true;
        }
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TriggerFinish")
        {
            Timer.timeOn = false;
            OnUILvlCompleted();
        }
    }
}
