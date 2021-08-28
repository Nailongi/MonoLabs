using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour
{

    public float speed;
    public bool isABee = false;
    private float Time0;
    public float amplitude;
    public float frequency;

    void Start()
    {
        Time0 = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
        if (isABee) 
        { 
            MoveUpDown();
        }
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    private void MoveUpDown()
    {
        transform.position = transform.position + Vector3.up * amplitude * Mathf.Sign(Mathf.Cos((Time0-Time.time) * frequency));
    }
}
