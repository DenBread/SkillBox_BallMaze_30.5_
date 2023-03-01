using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject _panelLvlComplete;

    private void OnEnable()
    {
        BallHandler.OnUILvlCompleted += ShowPanelLvlComplete;
    }

    private void OnDisable()
    {
        BallHandler.OnUILvlCompleted -= ShowPanelLvlComplete;
    }


    private void ShowPanelLvlComplete()
    {
        _panelLvlComplete.SetActive(true);

    }
}
