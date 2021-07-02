using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infinitebackground : MonoBehaviour
{
    public float backgroundLength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -backgroundLength){
            //Spawn New Background
            SpawnBackground();
        }
    } 

    void SpawnBackground(){
        var groundOffset = new Vector2(backgroundLength * 2f, 0f);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
