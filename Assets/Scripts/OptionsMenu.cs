using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private AudioManager _audioManager;
    [SerializeField] private Toggle themeToggle;
    [SerializeField] private Toggle sfxToggle;
    public AudioMixer audioMixer;

    private void Start()
    {
        if (themeToggle == null || sfxToggle == null) return;

        themeToggle.isOn = _audioManager.SoundSettings.themeSlider >= 0.5f;
        sfxToggle.isOn = _audioManager.SoundSettings.sfxSlider >= 0.5f;
    }

    public void SetSfxVol(float sliderValue)
    {
        audioMixer.SetFloat("sfxVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetThemeVol(float sliderValue)
    {
        audioMixer.SetFloat("themeVol", Mathf.Log10(sliderValue) * 20);
    }

    public void AllowSoundEffect(bool shouldAllow)
    {
        var value = shouldAllow ? 1 : 0.0001f;
        _audioManager.sfxSlider.value = value;
    }

    public void AllowTheme(bool shouldAllow)
    {
        var value = shouldAllow ? 1 : 0.0001f;
        _audioManager.themeSlider.value = value;
    }

    public void ResetSoundSettings(float sfxVol, float themeVol)
    {
        SetSfxVol(sfxVol);
        SetThemeVol(themeVol);
    }
}