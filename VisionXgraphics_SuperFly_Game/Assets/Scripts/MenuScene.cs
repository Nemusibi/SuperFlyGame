using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    private CanvasGroup fadeGroup;
    private float fadeInSpeed = 0.33f;

    private void Start()
    {
        // Grab the only CanvasGroup in the Scene
       // fadeGroup= findObjectOfType<CanvasGroup>();

        //Start with a white Screen;
        fadeGroup.alpha = 1;
    }
    private void Update()
    {
        //Fade-in
        fadeGroup.alpha = 1 - Time.timeSinceLevelLoad * fadeInSpeed;

    }
    //buttons
    public void OnPlayClick()
    {
      SceneManager.LoadScene("Game");
     
    }
    public void OnCloseClick()
    {
      Application.Quit();
    }
}
