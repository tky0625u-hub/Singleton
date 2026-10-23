using UnityEngine;
using UnityEngine.InputSystem;

public class Controll : MonoBehaviour
{
    [SerializeField] private AudioClip se;
    [SerializeField] private AudioClip bgm;

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
            SoundManager.Instance.PlayBGM(bgm, 0.5f);
        }

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            GamaSceneManager.Instance.ChangeScene("Title");
        }
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            GamaSceneManager.Instance.ChangeScene("Stage1");
        }
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            GamaSceneManager.Instance.ChangeScene("Stage2");
        }
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            SoundManager.Instance.PlaySE(se, 0.5f);
        }
    }
}
