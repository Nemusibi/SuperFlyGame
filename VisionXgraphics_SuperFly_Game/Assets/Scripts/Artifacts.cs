using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Artifacts : MonoBehaviour
{
    public int Artifact=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI()
    {
        GUIStyle style = new GUIStyle();
         style.richText = true;
         style.fontSize = 75;
         style.normal.textColor= Color.yellow;
        GUI.Label(new Rect(200,1000,700,700), "Artifacts: "+ Artifact,style);
    }
}
