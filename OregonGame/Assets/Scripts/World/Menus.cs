using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(1);
#pragma warning restore CS0618 // Type or member is obsolete
    }

}
