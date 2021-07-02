using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    public float backgroundLength;
    // Start is called before the first frame update
    void Start()
    {
        RandomHeight();
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
        var groundOffset = new Vector2(backgroundLength * 1.5f, 0f);
        transform.position = (Vector2)transform.position + groundOffset;
        RandomHeight();
    }
    private void RandomHeight(){
        var heightOffset = Random.Range(-1f, 1f);
        var groundOffset = new Vector2(0f, heightOffset);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
