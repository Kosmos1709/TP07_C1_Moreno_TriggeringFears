using UnityEngine;
using UnityEngine.UIElements;

public class HealUiEnemy : MonoBehaviour
{
    [SerializeField] private DeadEnemy deadEnemy;
    [SerializeField] private GameObject Life1;
    [SerializeField] private GameObject Life2;

    void Start()
    {
        deadEnemy = GetComponentInParent<DeadEnemy>();
    }
    void Update()
    {
        if (deadEnemy.health== 1)
        {
            Life2.SetActive(false);
        }
        if (deadEnemy.health <= 0)
        {
            Life1.SetActive(false);
        }
    }
}
