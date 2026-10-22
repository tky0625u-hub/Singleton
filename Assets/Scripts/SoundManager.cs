using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioSource bgm;
    [SerializeField] private AudioSource se;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        bgm.loop = true;
        DontDestroyOnLoad(gameObject);
    }

    private void OnDestroy()
    {
        if (Instance == this) Instance = null;
    }

    public void PlayBGM(AudioClip _clip, float _vol)
    {
        if (_clip == null) return; // nullチェック

        bgm.clip = _clip;
        bgm.volume = Mathf.Clamp01(_vol);
        bgm.Play();
    }

    public void StopBGM()
    {
        bgm.Stop();
    }

    public void ChangeBGMVol(float _vol) // 音量の範囲は1.0～0.0
    {
        bgm.volume = Mathf.Clamp01(_vol);
    }

    public void PlaySE(AudioClip _clip, float _vol)
    {
        if (_clip == null) return; // nullチェック

        se.PlayOneShot(_clip, Mathf.Clamp01(_vol));
    }
}
