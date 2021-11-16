using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onCollicion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Point")
        {
            Destroy(other.gameObject);
        }

       
        if (other.tag == "Ghost")
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
