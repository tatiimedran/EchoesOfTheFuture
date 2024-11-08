using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Animator animator; // Referencia al Animator

    private Rigidbody2D rb; // Referencia al Rigidbody2D
    private bool isGrounded = true; // Para saber si el personaje está en el suelo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (animator == null)
        {
            Debug.LogError("Animator no asignado en el Inspector");
        }
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D no encontrado en el GameObject");
        }
    }

    void Update()
    {
        // Movimiento horizontal
        float horizontalMov = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalMov * speed * Time.deltaTime, 0, 0));

        // Actualizar la animación con el parámetro xVelocity
        animator.SetFloat("xVelocity", Mathf.Abs(horizontalMov));

        // Saltar si se presiona la tecla de espacio y el personaje está en el suelo
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        animator.SetBool("isJumping", true);
        isGrounded = false;
    }

    // Método para detectar colisiones
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si la colisión es con el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("isJumping", false); // Desactivar la animación de salto
        }
    }
}
