using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesHandler : MonoBehaviour
{
    public void LoadScene(int idScene)
    {
        StartCoroutine(LoadLevel(idScene));
    }

    public Animator CircleAnimation;

    IEnumerator LoadLevel(int idScene)
    {
        CircleAnimation.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(idScene);
    }
}
