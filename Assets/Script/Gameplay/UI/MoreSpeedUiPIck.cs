using UnityEngine;
using TMPro;
public class MoreSpeedUiPIck : MonoBehaviour
{
    [SerializeField] private MovementPlayer movementPlayer;
    [SerializeField] private TextMeshProUGUI SpeedCountText;

    void Update()
    {
        SpeedCountText.text = "x " + movementPlayer.CDSpeed.ToString("00");
    }

}
