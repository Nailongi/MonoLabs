using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    readonly int NumberOfJumps = 2;
    private int JumpNo = 0;
    public float JumpForce;
    private bool IsOnGround;

    private Rigidbody2D RB;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && (JumpNo<NumberOfJumps))
        {
            JumpNo++;
            RB.AddForce(new Vector2(0,JumpForce),ForceMode2D.Force) ;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Floor")
        {
            JumpNo = 0;
        }
    }
}
