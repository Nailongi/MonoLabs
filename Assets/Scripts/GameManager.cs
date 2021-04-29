using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Renderer Background;
    private float BgVelocity=0.15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Background.material.mainTextureOffset += BgVelocity * new Vector2(1, 0) * Time.deltaTime;
    }
}
