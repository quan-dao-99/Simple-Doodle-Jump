using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SoundSettings {
	public float sfxSlider;
	public float themeSlider;

	public SoundSettings (float sfxSliderVal, float themeSliderVal)
	{
		sfxSlider = sfxSliderVal;
		themeSlider = themeSliderVal;
	}
}
