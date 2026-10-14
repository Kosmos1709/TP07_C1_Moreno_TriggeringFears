using UnityEngine;

public class DeadPlayer : MonoBehaviour
{
    [Header("Components player")]
    [SerializeField] private GameObject weapon;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioLose;

    [Header("Player var")]
    [SerializeField] public bool isDead;
    [SerializeField] private bool SoundPlaying = false;

    [Header("Panels")]
    [SerializeField] private GameObject losePanel;
  
    [Header("Pickeable 1 more life")]
    [SerializeField] private AudioSource PickeableSound;

   
    [SerializeField] public int health = 3;
    private void Awake()
    {
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
            float retroceso = 1f;

            if (collision.transform.position.x > transform.position.x)
            {
                transform.position += Vector3.left * retroceso;
            }
            else
            {
                transform.position += Vector3.right * retroceso;
            }
        }
    }
   

    public void PickeableSoundPlay()
    {
        PickeableSound.Play();
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
            transform.position = new Vector3(-4.5f, -1.5f, 0);
            weapon.SetActive(false);
            losePanel.SetActive(true);
            animator.SetBool("Dead", true);
            isDead = true;
            audioLose.Play();
            SoundPlaying = true;
        }
        

    }
}
