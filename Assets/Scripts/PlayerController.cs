using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f; //es la misma speed que el componente del script playercontroller en player
    public Animator animator;

    public float jumpForce = 4f; //rango de salto, en el inspector con 4 salta bien
    public float rayCastLength = 0.1f;
    public LayerMask floorLayer;

    private bool onFloor;
    private Rigidbody2D _rb; 

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    //codigo para que camine
    void Update()
    {
        float speedX = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        animator.SetFloat("movement", speedX * speed);

        if (speedX < 0 )
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (speedX > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        Vector3 posicion = transform.position;
        transform.position = new Vector3(speedX + posicion.x, posicion.y, posicion.z);


        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, rayCastLength, floorLayer);
        onFloor = hit.collider != null;
        if (onFloor && Input.GetKeyDown (KeyCode.Space))
        {
            _rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);  
        }
        animator.SetBool("onFloor", onFloor);
    }

    void OnDrawGizmos() //figura imaginaria, la veo en el editor, no en el juego
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * rayCastLength);

    }
}