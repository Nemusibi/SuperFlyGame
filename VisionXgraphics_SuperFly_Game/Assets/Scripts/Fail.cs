using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fail : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name =="Player" )
        SceneManager.LoadScene("Retry");
    }
}
