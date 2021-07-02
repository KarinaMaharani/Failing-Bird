using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float force;  
    public Rigidbody2D rb;
    public bool status = true;
    private score score;
    public AudioSource audioSource;
    public audio audio;
    public SpriteRenderer spriteRenderer;
    public Sprite deadSprite;

    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<score>();
    }

    // Update is called once per frame
    void Update()
    {
        //jump
        if(Input.GetKeyDown(KeyCode.Space) && status){
            audioSource.PlayOneShot(audio.jumpSound);
            Jump();
        }

        if(!status){
            deadChange();
        }
    }

    void Jump(){
        //Keep Jump consistent (keep velocity)
        rb.velocity = Vector2.zero;
        //Jump
        rb.AddForce(new Vector2(0f, force));
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.transform.tag == "Obstacles"){
            audioSource.PlayOneShot(audio.dieSound);
            Debug.Log("Bird hit Collision");
            status = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collider){
        if(collider.transform.tag == "Obstacles"){
            audioSource.PlayOneShot(audio.coinSound);
            Debug.Log("Scored a point");
            score.AddScore();
        }
    }

    void deadChange(){
        spriteRenderer.sprite = deadSprite;
    }
}
