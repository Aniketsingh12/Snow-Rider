using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finishline : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] ParticleSystem particle;
     void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            particle.Play();
            Invoke("Reload", 0.5f); 

        }
        
    }
    void Reload()
    {
        SceneManager.LoadScene(0);
    }
}
