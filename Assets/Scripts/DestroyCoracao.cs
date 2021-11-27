using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroyCoracao : MonoBehaviour
{
    [SerializeField]
    private Text contCoracao;
    private int contadorCoracao;
    public AudioSource pesquisa;
    public AudioClip[] destroyCoracao;

    void Start()
    {
        pesquisa = gameObject.GetComponent<AudioSource>();
        contadorCoracao = 0;
    }

    void Update()
    {
        contCoracao.text = "Coração: " + contadorCoracao;

        //Debug.Log( "Update DestroyCoracao"+ contadorCoracao);
        if (contadorCoracao == 5)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log( "OnTriggerEnter2D: "+colisao.CompareTag("Player"));
        if (collision.GetComponent<Coracao>())
        {
            contadorCoracao += 1;
            Destroy(collision.gameObject);
            pesquisa.clip = destroyCoracao[0];
            pesquisa.Play();
            //Debug.Log( "OnTriggerEnter2D DestroyCoracao"+ contadorCoracao);
        }
    }
}
