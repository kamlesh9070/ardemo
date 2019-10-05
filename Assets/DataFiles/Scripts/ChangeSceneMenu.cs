using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneMenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void MenuScene()
    {
        Debug.Log("Inside AkramYouth");
        SceneManager.LoadScene("MenuScene");
    }

    public void AkramYouth()
    {
        Debug.Log("Inside AkramYouth");
        SceneManager.LoadScene("AkramYouth");
    }

    // Update is called once per frame
    public void PlayVideo()
    {
        Debug.Log("Inside PlayVideo");
        SceneManager.LoadScene("Video");
    }
}
