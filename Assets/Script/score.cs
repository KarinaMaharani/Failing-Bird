using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int scoreCounter = 0;
    public Text scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = scoreCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(){
        scoreCounter++;
        scoreDisplay.text = scoreCounter.ToString();
    }
}
