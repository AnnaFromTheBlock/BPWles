using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScript : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    void Update()
    {
        Cursor.visible = false;
        Screen.lockCursor = true;
        Screen.lockCursor = false;
    }
}



