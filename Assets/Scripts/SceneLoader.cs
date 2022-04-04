using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void OnClickReload()
    {
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

    public void OnClickNext()
    {
        var index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(++index);
    }
}
