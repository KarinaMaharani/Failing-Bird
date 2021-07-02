using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollspeed : MonoBehaviour
{
    public float scrollSpeed;
    private bird bird;
    // Start is called before the first frame update
    void Start()
    {
        bird = FindObjectOfType<bird>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(bird.status){
            transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);
        }
    }
}
