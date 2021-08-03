using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Preloader : MonoBehaviour
{
    private CanvasGroup fadeGroup;
    private float loadTime;
    private float minimumLogoTime= 3.0f;//

    private void Start()
    {
        //Grab the only CanvasGroup in the Scene
        fadeGroup = FindObjectOfType<CanvasGroup>();

        // Start with a white Screen
        fadeGroup.alpha = 1;

        //pre load the game 

        //get a timestamp of the completion time

        //if loadtime is super, give it a small buffer time so we can appreciate the logo
        if(Time.time < minimumLogoTime)
        loadTime =minimumLogoTime;
        else 
        loadTime = Time.time;



    }
    private void Update()
    {
        //Fade-in
        if(Time.time <minimumLogoTime)
        {
            fadeGroup.alpha = 1-Time.time;
        }
        //Fade -Out
        if (Time.time > minimumLogoTime && loadTime !=0)
        {
            fadeGroup.alpha = Time.time - minimumLogoTime;
            if(fadeGroup.alpha >= 1)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
