using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float damage = 1f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float lifetime = 2f;
    [SerializeField] private float time = 0f;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        time += Time.deltaTime;
        if (time > lifetime)
        {
            Destroy(gameObject);
        }
    }

    internal void Shoot(float v)
    {
        Vector3 dir = new Vector3(v, 0, 0).normalized;
        rb.AddForce(dir * speed, ForceMode2D.Impulse);
    }


}
