using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string NameScene;

    private void Start()
    {
        PlayerPrefs.SetInt("Lose", 0);
    }

    public void OnClicks()
    {
        SceneManager.LoadScene(NameScene);
    }
}
