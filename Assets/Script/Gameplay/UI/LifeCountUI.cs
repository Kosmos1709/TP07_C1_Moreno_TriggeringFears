using UnityEngine;
using TMPro;    
public class LifeCountUI : MonoBehaviour
{
    [SerializeField] private DeadPlayer deadplayer;
    [SerializeField] private TextMeshProUGUI lifeCountText;

    void Update()
    {
        lifeCountText.text = "x" + deadplayer.health.ToString("00"); 
    }
}
