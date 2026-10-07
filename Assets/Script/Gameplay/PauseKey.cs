using UnityEngine;

public class PauseKey : MonoBehaviour
{
    [SerializeField] private KeyCode ESCKey = KeyCode.Escape;
    [SerializeField] private KeyCode PKey = KeyCode.P;
    [SerializeField] private GameObject PauseMenu;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(ESCKey) || Input.GetKeyDown(PKey))
        {
            PauseMenu.SetActive(!PauseMenu.activeSelf);
            if (PauseMenu.activeSelf)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
