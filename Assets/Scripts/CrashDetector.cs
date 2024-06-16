using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag =="Ground")
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke ("ReloadScene", loadDelay);
        }    
        
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
