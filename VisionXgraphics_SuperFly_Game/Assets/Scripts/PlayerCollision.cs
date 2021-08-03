
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionIn)
    {
        
        if (collisionIn.collider.tag =="enemy")
        {

          //  SceneManager.LoadScene("Retry");
        }
       
    }
}
