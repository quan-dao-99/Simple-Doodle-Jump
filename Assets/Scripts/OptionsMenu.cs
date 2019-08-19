using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {
	public AudioMixer audioMixer;
	public void SetMasterVolume (float sliderValue)
    {
        audioMixer.SetFloat("masterVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetSFXVol (float sliderValue)
    {
        audioMixer.SetFloat("sfxVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetThemeVol (float sliderValue)
    {
        audioMixer.SetFloat("themeVol", Mathf.Log10(sliderValue) * 20);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void ResetSoundSettings(float masterVol, float sfxVol, float themeVol)
    {
        SetMasterVolume(masterVol);
        SetSFXVol(sfxVol);
        SetThemeVol(themeVol);
    }
}
