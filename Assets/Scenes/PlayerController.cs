using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;  // Velocidad de movimiento del jugador.
    private Rigidbody rb;    // Referencia al componente Rigidbody.

    void Start()
    {
        rb = GetComponent<Rigidbody>();  // Obtener el componente Rigidbody del jugador.
    }

    void FixedUpdate()
    {
        // Obtener la entrada del teclado para movimiento horizontal y vertical.
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Crear un vector de movimiento usando las entradas.
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Aplicar una fuerza al Rigidbody para mover el jugador.
        rb.AddForce(movement * speed);
        // `AddForce` mueve el jugador aplicando una fuerza a su Rigidbody.
        // `FixedUpdate` se usa para aplicar física, asegurando un movimiento consistente.
    }
}

