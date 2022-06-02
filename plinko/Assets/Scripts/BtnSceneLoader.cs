using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnSceneLoader : MonoBehaviour
{

    public void OnClickLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
