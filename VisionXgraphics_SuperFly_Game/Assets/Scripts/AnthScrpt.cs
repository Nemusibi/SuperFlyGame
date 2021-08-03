using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnthScrpt : MonoBehaviour
{
    public AudioSource tingSource;
    public GameObject pickupEffect;
    // Start is called before the first frame update
    void Start()
    {
        tingSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        if(other.name =="Player")
        {
            
            other.GetComponent<Artifacts>().Artifact++;
            //Add 1 to Artifacts
            Destroy(gameObject);
            tingSource.Play();
            Pickup();
        }
        else if(other.gameObject.tag =="enemy")
        {
           SceneManager.LoadScene("Retry");
        }
        void Pickup()
        {
            //Spawn a cool effeffect
            Instantiate(pickupEffect,transform.position,transform.rotation);

            Destroy(gameObject);
        }
    }
}
