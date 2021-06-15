using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{
    public InputField input;
    private void Awake()
    {
        input.text = PlayerPrefs.GetString("name");
    }

    public void SavePlayerName()
    {
        string name = input.text;
        PlayerPrefs.SetString("name", name);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
