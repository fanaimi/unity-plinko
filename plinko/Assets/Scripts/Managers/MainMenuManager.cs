using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    private void Start()
    {
        AudioManager.Instance.Play("menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
