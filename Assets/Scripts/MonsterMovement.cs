using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D rb;
    public Rigidbody2D breastPrefab;

    float timer = 0.0f;
    int seconds = 0;

    void Start () 
    {
        _animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

	void Update () 
    {

        // Redefina a posição se cair do mundo
        if (this.transform.position.y < -7){            
            this.transform.position = new Vector3(-10, 10, 0);
        }

        _animator.Play(Animator.StringToHash("Fly"));

        // Movimento e Ações
        rb.rotation = -8f;
        transform.Translate(Vector2.right * 0.005f, Space.World);
        
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        //Debug.Log( "seconds: " +seconds);
        
        if(seconds == 2)
        {
            Rigidbody2D breastInstance;
            breastInstance = Instantiate(breastPrefab, (this.transform.position + new Vector3(0, -1f, 0)), this.transform.rotation) as Rigidbody2D;
            breastInstance.AddForce(-5 * rb.transform.up, ForceMode2D.Impulse);

            Rigidbody2D breastInstance2;
            breastInstance2 = Instantiate(breastPrefab, (this.transform.position + new Vector3(0, 1f, 0)), this.transform.rotation) as Rigidbody2D;
            breastInstance2.AddForce(5 * rb.transform.up, ForceMode2D.Impulse);

            timer = 0;
        }
    }
}
