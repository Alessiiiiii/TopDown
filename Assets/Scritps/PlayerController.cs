using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;
    public float fuerzaSalto = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Mover();
        if (Input.GetKeyDown(KeyCode.Space)) // Salto con barra espaciadora
        {
            Saltar();
        }
    }

    void Mover()
    {
        float movimiento = Input.GetAxis("Horizontal") * velocidad;
        rb.linearVelocity = new Vector2(movimiento, rb.linearVelocity.y);
    }

    void Saltar()
    {
        rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }
}