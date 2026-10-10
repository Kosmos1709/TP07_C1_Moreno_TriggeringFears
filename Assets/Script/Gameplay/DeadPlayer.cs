using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    [SerializeField] private GameObject weapon;
    [SerializeField] private Rigidbody2D rb ;
    [SerializeField] private Animator animator;
    [SerializeField] public bool isDead;
    [SerializeField] private AudioSource audioLose;
    [SerializeField] private bool SoundPlaying = false;

    [SerializeField] private GameObject losePanel;
    /// <summary>
    /// crear un panel de derrota para ponerlo cuando se quede sin vida 
    /// y poner un boton de reiniciar nivel y otro de volver al menu principal
    /// </summary>
    [SerializeField] public int health = 3;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        health = 3;
        SoundPlaying = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("void"))
        {
            health--;
            transform.position = new Vector3(-4.5f, -1.5f, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            health--;
            transform.position = new Vector3(-4.5f, -1.5f, 0);
        }
    }
    public void Update()
    {
        if (health > 0)
        {
            isDead = false;
            weapon.SetActive(true);
            animator.SetBool("Dead", false);
        }
        if (health <= 0 && !SoundPlaying)
        {
            health = 0;
            weapon.SetActive(false);
            losePanel.SetActive(true);
            animator.SetBool("Dead", true);
            isDead = true;
            audioLose.Play();
            SoundPlaying = true;
        }
        

    }
}
