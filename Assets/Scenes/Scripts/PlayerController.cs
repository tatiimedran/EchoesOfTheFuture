using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int score;
    private Rigidbody2D _rb;
    private BoxCollider2D boxCollider;
    private bool _lookRight = true;

    private float remainingJumps; // saltos restantes
    public float jumpForce = 4f;
    public int jumpsMax = 10000;
    public LayerMask floorLayer;
    public float speed = 2f;


    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        remainingJumps = jumpsMax;

    }

    void Update()
    {
        ProcessMotion(); // procesar movimiento
        ProcessJump(); // procesar salto
    }

    bool _onFloor() // está en suelo
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.x, boxCollider.bounds.size.y), 0f, Vector2.down, 0.2f, floorLayer);
        return raycastHit.collider != null;
    }

    void ProcessJump() // procesar salto
    {
        if (_onFloor())
        {
            remainingJumps = jumpsMax;
        }

        if (Input.GetKeyDown(KeyCode.Space) && remainingJumps > 0)
        {
            remainingJumps--; // es lo mismo que poner remainingJumps = remainingJumps - 1;
            _rb.velocity = new Vector2(_rb.velocity.x, 0f); // esto es lo que hace que salte bien
            _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    void ProcessMotion() // movimiento horizontal a la derecha
    {
        float speedX = Input.GetAxis("Horizontal"); // speedX = inputMovimiento
        _rb.velocity = new Vector2(speedX * speed, _rb.velocity.y);
        ManageOrientation(speedX);
    }

    void ManageOrientation(float speed) // gestionar orientación del personaje izq o derecha
    {
        if ((_lookRight && speed < 0) || (!_lookRight && speed > 0))
        {
            _lookRight = !_lookRight;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision. gameObject.tag == "MobilePlatform")
        {
            transform.parent = collision.transform;
        }
    }

    private void OnCollisionExit2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "MobilePlatform")
        {
            transform.parent = null;
        }
    }
    //agregue
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SpecialSphere")
        {
            Debug.Log("Game Over"); FindObjectOfType<GameOver>().ShowGameOver();

        }
    }

}
