using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }

    public void returntodesktop()
    {
        Application.Quit();
    }
    public void QuitGame()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(0);
#pragma warning restore CS0618 // Type or member is obsolete
    }

    public void Restart()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(1);
#pragma warning restore CS0618 // Type or member is obsolete
    }
    public void Credits()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(3);
#pragma warning restore CS0618 // Type or member is obsolete
    }

}
