using UnityEngine;

public class MoreSpeedPick : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            MovementPlayer pickSpeed = collision.GetComponent<MovementPlayer>();
            DeadPlayer deadplayer = collision.GetComponent<DeadPlayer>();
            if (pickSpeed != null)
            {
                pickSpeed.MoreSpeedOn();
                deadplayer.PickeableSoundPlay();
            }
            gameObject.SetActive(false);
        }
    }
}
