using UnityEngine;

public class MovimentEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float speed = 5f;
    private DeadEnemy deadEnemy;

    [SerializeField] private Animator animator;

    void Start()
    {
        deadEnemy = GetComponent<DeadEnemy>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            speed *= -1;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            speed *= -1;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            speed *= -1;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
    void Update()
    {
        if (deadEnemy.isDead==false)
        {
          enemyPrefab.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
