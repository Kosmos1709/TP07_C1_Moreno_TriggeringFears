
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float parallaxFactor = 0.5f;
    [SerializeField] private MovementPlayer movementPlayer;

    private float direction;
    private float startPositionX;
    private float backgroundWidth;

    private void Start()
    {
        movementPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementPlayer>();

        startPositionX = transform.position.x;

        SpriteRenderer sprite = GetComponent<SpriteRenderer>();

        backgroundWidth = sprite.bounds.size.x;
    }

    private void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");

        float playerDirection = Mathf.Sign(movementPlayer.transform.localScale.x);

        if (direction != 0)
        {
            transform.position += Vector3.left * playerDirection * speed * parallaxFactor * Time.deltaTime;
        }

        if (transform.position.x < startPositionX - backgroundWidth)
        {
            transform.position += Vector3.right * backgroundWidth * 2f;
        }
        else if (transform.position.x > startPositionX + backgroundWidth)
        {
            transform.position += Vector3.left * backgroundWidth * 2f;
        }
    }
}
