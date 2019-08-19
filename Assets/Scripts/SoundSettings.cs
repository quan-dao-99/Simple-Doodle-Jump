using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SoundSettings {
	public float masterSlider;
	public float sfxSlider;
	public float themeSlider;

	public SoundSettings (float masterSliderVal, float sfxSliderVal, float themeSliderVal)
	{
		masterSlider = masterSliderVal;
		sfxSlider = sfxSliderVal;
		themeSlider = themeSliderVal;
	}
}
