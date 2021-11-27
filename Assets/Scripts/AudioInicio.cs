using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioInicio : MonoBehaviour
{
    [SerializeField]

    public AudioSource somJogo;
    public AudioClip[] inicioJogo;

    void Start()
    {
        somJogo = gameObject.GetComponent<AudioSource>();
    }

    public void iniciarJogo(){
        somJogo.clip = inicioJogo[0];        
        somJogo.Play();
    }
    
}
