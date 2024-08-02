using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapstrength;
    public logicscript logic;
    public bool birdisalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdisalive == true)
        {
            myrigidbody.velocity = Vector2.up * flapstrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    { 
        logic.gameover();
        birdisalive = false;
    }
}
