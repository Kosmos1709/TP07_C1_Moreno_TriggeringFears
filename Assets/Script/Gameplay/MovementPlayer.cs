using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 6f;
    [SerializeField] private Animator animator;
    [SerializeField] private KeyCode right = KeyCode.D;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode jump = KeyCode.Space;

    [SerializeField] private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey(right)||Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(left)||Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(jump))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }


        //condicional para la animacion de movimiento 
        if (Input.GetKey(right) || Input.GetKey(left) ||
            Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetFloat("Movement", 1f);
        }
        else
        {
            animator.SetFloat("Movement", 0f);
        }
    }
}
