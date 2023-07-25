using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenceCtrl : MonoBehaviour
{
 
    public void PlayScence()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void ExitScence()
    {
        SceneManager.LoadScene(0);
    }

    public void QuitScence()
    {
        Application.Quit();
    }
}
