using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider sfxSlider;
    public Slider themeSlider;
    public SoundSettings SoundSettings => soundSettings;

    private SoundSettings soundSettings;
    private float lastSFXSlider = 1;
    private float lastThemeSlider = 1;
    private AudioSource themeSource;

    private void Awake()
    {
        soundSettings = SaveSystem.LoadSoundSettings();
    }

    private void Start()
    {
        if (!IsFileAvailable()) return;
        
        sfxSlider.value = soundSettings.sfxSlider;
        themeSlider.value = soundSettings.themeSlider;

        lastSFXSlider = soundSettings.sfxSlider;
        lastThemeSlider = soundSettings.themeSlider;
    }

    public void SaveSoundSettings()
    {
        lastSFXSlider = sfxSlider.value;
        lastThemeSlider = themeSlider.value;
        SaveSystem.SaveSoundSettings(sfxSlider.value, themeSlider.value);
    }

    public void ResetSound()
    {
        var optionsMenu = FindObjectOfType<OptionsMenu>();
        optionsMenu.ResetSoundSettings(lastSFXSlider, lastThemeSlider);
    }

    private bool IsFileAvailable()
    {
        return soundSettings != null;
    }
}