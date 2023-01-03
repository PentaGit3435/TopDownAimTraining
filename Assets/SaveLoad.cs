using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveLoad
{
    public static void Save<T>(string name, T data)
    {
        string path = Application.dataPath + "/Data/";
        string jsonData = JsonUtility.ToJson(data);

        if (!File.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        File.WriteAllText(path + name, jsonData);
    }
    public static void Load<T>(string fileName, T scriptableObject) 
    {
        string path = Application.dataPath + "/data/" + fileName;
        if (File.Exists(path))
        {
            JsonUtility.FromJsonOverwrite(File.ReadAllText(path), scriptableObject);
        }
    }
}
