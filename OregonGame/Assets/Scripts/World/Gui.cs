using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Restart()
    {
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel("SpilVerden");
#pragma warning restore CS0618 // Type or member is obsolete
    }
    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("You have clicked the button!");
    }
}