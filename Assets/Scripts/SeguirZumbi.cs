using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirZumbi : MonoBehaviour
{
    public float velocidadeDoInimigo;
    private Transform posicaoDoJogador;

    // Start is called before the first frame update
    void Start()
    {
        posicaoDoJogador = GameObject.FindGameObjectWithTag("Zumbi").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(posicaoDoJogador.gameObject != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, posicaoDoJogador.position, velocidadeDoInimigo * Time.deltaTime);
        }
    }
}
