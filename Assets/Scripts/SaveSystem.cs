using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveSoundSettings(float sfxSlider, float themeSlider)
    {
        var formatter = new BinaryFormatter();
        var path = Application.persistentDataPath + "/sound.settings";
        var stream = new FileStream(path, FileMode.Create);

        var data = new SoundSettings(sfxSlider, themeSlider);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SoundSettings LoadSoundSettings()
    {
        var path = Application.persistentDataPath + "/sound.settings";
        if (File.Exists(path))
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(path, FileMode.Open);

            var data = formatter.Deserialize(stream) as SoundSettings;
            stream.Close();

			return data;
        }

        Debug.LogError("Save file not found in " + path);
        return null;
    }
}
