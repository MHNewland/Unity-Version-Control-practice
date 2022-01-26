using TMPro;
using UnityEngine;

public class HSManager : MonoBehaviour
{
    public TextMeshProUGUI hslist;
    public void Start()
    {
        PersistenceManager.instance.ShowHS();
        string listText = "High Score\n" + PersistenceManager.instance.highScore.hsName + " : \t" + PersistenceManager.instance.highScore.hsScore;


        hslist.text = listText;
    }
}
