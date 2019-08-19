using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveSoundSettings(float masterSlider, float sfxSlider, float themeSlider)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/sound.settings";
        FileStream stream = new FileStream(path, FileMode.Create);

        SoundSettings data = new SoundSettings(masterSlider, sfxSlider, themeSlider);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SoundSettings LoadSoundSettings()
    {
        string path = Application.persistentDataPath + "/sound.settings";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SoundSettings data = formatter.Deserialize(stream) as SoundSettings;
            stream.Close();

			return data;
        } else
		{
			Debug.LogError("Save file not found in " + path);
			return null;
		}
    }
}
