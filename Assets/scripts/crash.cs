using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class crash : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ground")
        {
            FindObjectOfType<controll>().Stopped();
            particle.Play();
            Invoke("ReloadScene", 0.5f);
        }
    }
    void ReloadScene()
    {
SceneManager.LoadScene(0);
    }
}
