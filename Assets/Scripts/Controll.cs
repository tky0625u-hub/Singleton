using UnityEngine;
using UnityEngine.InputSystem;

public class Controll : MonoBehaviour
{
    [SerializeField] private string[] SceneNames;
    private int scene = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current == null) return;

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            GamaSceneManager.Instance.ChangeScene(SceneNames[scene]);
            scene += 1;
            if (scene >= SceneNames.Length) scene = 0;
        }
    }
}
