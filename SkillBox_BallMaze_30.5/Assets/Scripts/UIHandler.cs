using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private GameObject _panelLvlComplete;
    [SerializeField] private GameObject _panelLeveFaild;

    private void OnEnable()
    {
        BallHandler.OnUILvlCompleted += ShowPanelLvlComplete;
        BallHandler.OnUILvlFailed += ShowPanelLvlFaild;
    }

    private void OnDisable()
    {
        BallHandler.OnUILvlCompleted -= ShowPanelLvlComplete;
        BallHandler.OnUILvlFailed -= ShowPanelLvlFaild;
    }


    private void ShowPanelLvlComplete()
    {
        _panelLvlComplete.SetActive(true);

    }

    private void ShowPanelLvlFaild()
    {
        _panelLeveFaild.SetActive(true);
    }
}
