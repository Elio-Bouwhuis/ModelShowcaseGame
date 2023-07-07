using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    void Start()
    {
        Cursor.visible = true;
    }

    public void QuitGame()
    {
#if     UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");
    }
}
