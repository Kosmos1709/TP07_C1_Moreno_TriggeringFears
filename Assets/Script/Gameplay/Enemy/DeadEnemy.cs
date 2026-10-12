using UnityEngine;

public class DeadEnemy : MonoBehaviour
{
    private Animator animator;
    [SerializeField] public int health = 2;
    [SerializeField] private float damage = 1f;
    [SerializeField] public bool isDead = false;
    [SerializeField] private AudioSource deadSound;
    [SerializeField] public float countDown = 1f;
    [SerializeField] private ParticleSystem deathEffect;
    void Awake()
    {
        isDead = false;
        health = 2;
        animator = GetComponent<Animator>();
        animator.SetBool("Dead", false);
        deathEffect = GetComponentInChildren<ParticleSystem>();
        deathEffect.Stop();
    }

    public void TakeDamage(float damage)
    {
        health -= (int)damage;
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        countDown = 1f;
        animator.SetBool("Dead", true);
        deathEffect.Play(); 
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
