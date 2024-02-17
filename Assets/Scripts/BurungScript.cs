using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurungScript : MonoBehaviour
{
    public float terbang;
    public Rigidbody2D myRigidbody;
    public LogicScript logic;
    public float timer = 0;
    public bool gameDimulai = false;

    // Apakah burungnya hidup
    public bool hidup = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < 3){
            timer = timer + Time.deltaTime;
        }else{
            gameDimulai = true;
            myRigidbody.gravityScale = 3;
        }
        //Jika inpput pengguna spasi dan bburungnya hidup, maka burungnya bisa loncat
        if(Input.GetKeyDown(KeyCode.Space) && hidup && gameDimulai){
            myRigidbody.velocity = Vector2.up * terbang;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        logic.gameover();
        // Saat ketabrak dengan objek lain, burungnya tidak hidup
        hidup = false;
    }
}
