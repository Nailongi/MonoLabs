using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour
{

    public float speed;


    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    private void MoveLeft()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
