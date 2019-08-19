using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private SoundSettings soundSettings;
    private float lastMasterSlider = 1;
    private float lastSFXSlider = 1;
    private float lastThemeSlider = 1;
    private AudioSource themeSource;
    public Slider masterSlider;
    public Slider sfxSlider;
    public Slider themeSlider;
    // public GameplayUI gameplayUI;

    private void Awake()
    {
        LoadSoundSettings();
    }

    private void LoadSoundSettings()
    {
        if (isFileAvailable())
        {
            // OptionsMenu optionsMenu = FindObjectOfType<OptionsMenu>();

            masterSlider.value = soundSettings.masterSlider;
            sfxSlider.value = soundSettings.sfxSlider;
            themeSlider.value = soundSettings.themeSlider;

            lastMasterSlider = soundSettings.masterSlider;
            lastSFXSlider = soundSettings.sfxSlider;
            lastThemeSlider = soundSettings.themeSlider;
        }
    }

    public void SaveSoundSettings()
    {
        lastMasterSlider = masterSlider.value;
        lastSFXSlider = sfxSlider.value;
        lastThemeSlider = themeSlider.value;
        SaveSystem.SaveSoundSettings(masterSlider.value, sfxSlider.value, themeSlider.value);
    }

    public void ResetSound()
    {
        // if (isFileAvailable())
        // {
            OptionsMenu optionsMenu = FindObjectOfType<OptionsMenu>();
			optionsMenu.ResetSoundSettings(lastMasterSlider, lastSFXSlider, lastThemeSlider);
        // }
    }

    private bool isFileAvailable()
    {
        soundSettings = SaveSystem.LoadSoundSettings();
        if (soundSettings == null)
        {
            return false;
        }
        return true;
    }
}
