using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroyVirus : MonoBehaviour
{
    [SerializeField]
    private Text contVirus;
    private int contadorVirus;
    public AudioSource pesquisa;
    public AudioClip[] destroyVirus;

    void Start()
    {
        pesquisa = gameObject.GetComponent<AudioSource>();
        contadorVirus = 0;
    }

    void Update()
    {
        contVirus.text = "Vírus: " + contadorVirus;

        //Debug.Log( "Update DestroyVirus"+ contadorVirus);
        if (contadorVirus == 5)
        {
            SceneManager.LoadScene("Parabens");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log( "OnTriggerEnter2D: "+colisao.CompareTag("Player"));
        if (collision.GetComponent<Virus>())
        {
            contadorVirus += 1;
            Destroy(collision.gameObject);
            pesquisa.clip = destroyVirus[0];
            pesquisa.Play();
            //Debug.Log( "OnTriggerEnter2D DestroyVirus"+ contadorVirus);
        }
    }
}
