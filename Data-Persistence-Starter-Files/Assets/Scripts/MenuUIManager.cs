using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public TextMeshProUGUI playerName;

    public void Start()
    {
        if (PersistenceManager.instance.playerName == "") PersistenceManager.instance.LoadName();
        playerName.text = PersistenceManager.instance.playerName;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeName()
    {
        SceneManager.LoadScene(2);
    }

    public void ViewHighScores()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }
}
