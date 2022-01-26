using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NameChangeManager : MonoBehaviour
{
    public TextMeshProUGUI newName;
    public void SaveName()
    {
        if (PersistenceManager.instance != null)
        {
            PersistenceManager.instance.playerName = newName.text;
        }
    }
}
