using UnityEngine;

public class MoreLifesPIck : MonoBehaviour
{
 

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            DeadPlayer pickLife = collision.GetComponent<DeadPlayer>();
            if (pickLife != null)
            {
                pickLife.health++;
                pickLife.PickeableSoundPlay();
            }
            gameObject.SetActive(false);
        }
    }
    
}
