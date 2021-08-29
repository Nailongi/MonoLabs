using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour
{

    public float speed;
    public bool isABee = false;
    private float Time0;
    private float y0;
    public float amplitude;
    public float frequency;
    private float rdmfase;

    void Start()
    {
        y0 = transform.position.y;
        Time0 = Time.time;
        rdmfase = Random.Range(0f,2*Mathf.PI);
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
        if (isABee) 
        { 
            MoveUpDown3();
        }
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }

    private void MoveUpDown1()
    {
        transform.position = transform.position + Vector3.up * amplitude * Mathf.Sign(Mathf.Cos((Time0-Time.time) * frequency));
    }

    private float Sawtooth(float t)
    {
        return Mathf.Abs(t - Mathf.Floor(t) - 0.5f) - 0.25f;
    }

    private void MoveUpDown2()
    {
        transform.position = new Vector3(transform.position.x, y0 + amplitude * Sawtooth(Time.time * frequency+rdmfase), transform.position.z);
    }

    private void MoveUpDown3()
    {
        transform.position = new Vector3(transform.position.x, y0 + amplitude * Mathf.Cos(Time.time * frequency + rdmfase), transform.position.z);
    }

    
}
