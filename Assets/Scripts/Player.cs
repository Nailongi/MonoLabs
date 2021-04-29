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
        Jump2();

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Floor")
        {
            JumpNo = 0;
        }
    }

    //Con este salto al apretar dos veces rápido el salto es más alto
    //Y al apretar dos veces lente el salto es más controlado
    private void Jump1()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && (JumpNo < NumberOfJumps))
        {
            JumpNo++;
            RB.AddForce(new Vector2(0.0f, JumpForce), ForceMode2D.Impulse);
        }
    }

    //Con este salto el cambio de la velocidad es inmediato, 
    //esto asegura que el primer y segundo salto sean de la misma fuerza
    private void Jump2()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && (JumpNo < NumberOfJumps))
        {
            JumpNo++;
            RB.velocity = new Vector2(0.0f, JumpForce);
        }
    }
}
