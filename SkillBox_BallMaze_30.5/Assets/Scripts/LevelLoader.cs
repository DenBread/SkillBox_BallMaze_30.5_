using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Animator CircleAnimation;

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(1); 
    }
}
