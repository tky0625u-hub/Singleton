using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamaSceneManager : MonoBehaviour
{
    public static GamaSceneManager Instance { get; private set; }
    [SerializeField] private string[] SceneNames;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    public void ChangeScene(string _scene)
    {
        if (Array.IndexOf(SceneNames, _scene) < 0)
        {
            Debug.Log("登録されていないシーンです。"); 
            return;
        }
        SceneManager.LoadScene(_scene);
    }
}
