using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesHandler : MonoBehaviour
{
    public void LoadScene(int idScene)
    {
        SceneManager.LoadScene(idScene);
    }
}
