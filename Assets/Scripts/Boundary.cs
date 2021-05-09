using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    private float leftBound = 5.0f;
    private float topBound = 2.5f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        DestroyBoundary();
        TopBoundary();
    }

    private void DestroyBoundary()
    {
        if (transform.position.x < -leftBound)
        {
            Destroy(gameObject);

        }
    }

    private void TopBoundary()
    {
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound);

        }
    }
}
