using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PersistenceManager : MonoBehaviour
{
    public static PersistenceManager instance;
    public string playerName;
    public HighScore highScore = new HighScore() { hsName = "", hsScore = 0 };

    private void Awake()
    {
        if(instance == null)
        {
            Debug.Log("null");
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
            return;
        }
    }

    [Serializable]
    class SaveData
    {
        public HighScore HS;
        public string lastPlayer;
    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.HS = highScore;
        data.lastPlayer = playerName;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void ShowHS()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highScore = data.HS;

        }
        else
        {
            Debug.Log("file not found");
        }
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            playerName = data.lastPlayer;

        }
        else
        {
            Debug.Log("file not found");
        }

    }
}
