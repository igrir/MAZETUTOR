using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmileyScript : MonoBehaviour
{
    public AudioSource bounce;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Menu");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        bounce.Play();
    }
}
