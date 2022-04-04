using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject WinPanel;
    public GameObject FailPanel;

    private void Awake()
    {
        var bird = FindObjectOfType<Bird>();
        if (bird)
            bird.OnLevelProgression += OnLevelProgression;
    }

    private void OnDestroy()
    {
        var bird = FindObjectOfType<Bird>();
        if (bird)
            bird.OnLevelProgression -= OnLevelProgression;
    }

    public void OnLevelProgression(bool status)
    { 
        if(status)
            WinPanel.SetActive(true);
        else
            FailPanel.SetActive(true);
    }
  
}
