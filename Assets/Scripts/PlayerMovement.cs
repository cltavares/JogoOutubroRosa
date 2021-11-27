
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody2D rb;
    public Rigidbody2D breastPrefab;
    private float deltaX, deltaY;

    float timer = 0.0f;
    int seconds = 0;

    void Start () 
    {
        _animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

	void Update () 
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 Touchpos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = Touchpos.x - transform.position.x;
                    deltaY = Touchpos.y - transform.position.y;
                    break;
                
                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(Touchpos.x - deltaX, Touchpos.y - deltaY));
                    break;

                case TouchPhase.Ended:
                    rb.velocity= Vector2.zero;
                    break;
                    
            }
        }
        
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
