using UnityEngine;

public class DeadEnemy : MonoBehaviour
{
    private Animator animator;
    [SerializeField] public float health = 2f;
    [SerializeField] private float damage = 1f;
    [SerializeField] public bool isDead = false;
    [SerializeField] private AudioSource deadSound;
    [SerializeField] public float countDown = 1f;
    void Awake()
    {
        isDead = false;
        health = 2f;
        animator = GetComponent<Animator>();
        animator.SetBool("Dead", false);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0f)
        {
            Die();
        }
    }
    void Die()
    {
        countDown = 1f;
        animator.SetBool("Dead", true);
        deadSound.Play();

    }
    void Update()
    {
        if (health<=0)
        {
            countDown -= Time.deltaTime;
            if (countDown <= 0)
            {
                Destroy(gameObject);
            }
            health = 0;
            isDead = true;

        }
    }
}
