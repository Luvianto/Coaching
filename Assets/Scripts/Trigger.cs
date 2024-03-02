using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public LogicScript logic;
    public AudioScript audioSfx;

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        audioSfx = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.layer == 3){
            logic.addScore(score);
            audioSfx.playSfx(audioSfx.coinSfx);
        }
    }
}
