using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private float _ballSpeed = 1f;

    private void Start()
    {
        if(_inputHandler == null) { Debug.LogError("input handler не назначен"); }
    }

    private void Update()
    {
        MoveBall();
    }

    private void MoveBall()
    {
        if(_inputHandler.IsThereTouchOnScreen())
        {
            Vector2 currDeltaPos = _inputHandler.GetTouchDeltaPosition();
            currDeltaPos *= _ballSpeed;
            Vector3 newGravityVector = new Vector3(currDeltaPos.x, Physics.gravity.y, currDeltaPos.y);
            Physics.gravity = newGravityVector;
            
            if(transform.position.y > 0.5f)
            {
                newGravityVector = new Vector3(currDeltaPos.x, -9.81f, currDeltaPos.y);
            }
        }
    }
}
