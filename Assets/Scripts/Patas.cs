using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patas : MonoBehaviour
{
    public Player myPlayer;
    public float KillJumpForce;

    private void Start()
    {
        myPlayer = GameObject.Find("Player").GetComponent<Player>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            //Debug.Log("Lo matatis");
            Destroy(other.gameObject);
            myPlayer.JumpNo = 1;
            myPlayer.RB.velocity = new Vector2(0.0f, KillJumpForce);
        }
    }
}
