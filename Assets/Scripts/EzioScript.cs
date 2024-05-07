using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpStr;
    public LogicScript logic;
    public bool ezioIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ezioIsAlive)
        {
            myRigidbody.velocity = Vector2.up * jumpStr;
        }
        if (transform.position.y < -20)
        {
           
            logic.gameOver();
            ezioIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        ezioIsAlive = false;
    }
}
