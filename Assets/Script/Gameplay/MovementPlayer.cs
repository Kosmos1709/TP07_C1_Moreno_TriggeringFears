using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float jumpForce = 6f;
    [SerializeField] private bool InFloor = false;


    [SerializeField] private Animator animator;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform transformbullet;


    [SerializeField] private KeyCode right = KeyCode.D;
    [SerializeField] private KeyCode left = KeyCode.A;
    [SerializeField] private KeyCode jump = KeyCode.Space;

    [SerializeField] private Bullets bulletPrefab;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Floor"))
        {
            InFloor = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Floor"))
        {
            InFloor = false;
        }
    }
    void Update()
    {
        if (Input.GetKey(right)||Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKey(left)||Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKeyDown(jump))
        {
            if (InFloor == true)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            Bullets bullets = Instantiate(bulletPrefab, transformbullet.position, Quaternion.identity);
            bullets.Shoot(Mathf.Sign(transform.localScale.x));
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
