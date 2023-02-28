using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour
{
    private void Update()
    {
        Cursor.visible = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
