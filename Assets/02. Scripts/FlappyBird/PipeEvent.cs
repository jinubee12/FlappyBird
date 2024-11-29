using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEvent : MonoBehaviour
{
    public GameObject endUI;
    public SoundManager soundManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("GameOver");
            endUI.SetActive(true);
            soundManager.OnEventSound(3);
        }
    }
    
}
