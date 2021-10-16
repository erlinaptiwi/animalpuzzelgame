using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenuscript : MonoBehaviour
{
    // Start is called before the first frame update
    public void mulaigame()
    {
        SceneManager.LoadScene("puzzel");
    }

    public void kembalikemenu()
    {
        SceneManager.LoadScene("mainmenu");
    }

    // Update is called once per frame
    public void exitgame()
    {
        Application.Quit();
    }
}
