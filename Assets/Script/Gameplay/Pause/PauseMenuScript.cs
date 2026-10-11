using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{

    [SerializeField] private Button BtnContinue;
    [SerializeField] private Button BtnSettings;
    [SerializeField] private Button BtnCredits;
    [SerializeField] private Button BtnBack;


    [SerializeField] private GameObject PanelVolume;
    [SerializeField] private GameObject PanelCredits;
    [SerializeField] private GameObject PauseMenu;





    private void Awake()
    {
        BtnContinue.onClick.AddListener(OnButtonStartClick);
        BtnSettings.onClick.AddListener(OnButtonVolumeClick);
        BtnCredits.onClick.AddListener(OnButtonCreditsClick);
        BtnBack.onClick.AddListener(OnButtonHTPClick);


    }
    private void OnDestroy()
    {
        BtnContinue.onClick.RemoveAllListeners();
        BtnSettings.onClick.RemoveAllListeners();
        BtnCredits.onClick.RemoveAllListeners();
        BtnBack.onClick.RemoveAllListeners();
    }


    private void OnButtonStartClick()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }
    private void OnButtonVolumeClick()
    {
        Debug.Log("Clickbutton Volume");
        PanelVolume.SetActive(!PanelVolume.activeSelf);
    }
    private void OnButtonCreditsClick()
    {
        Debug.Log("Clickbutton Credits");
        PanelCredits.SetActive(!PanelCredits.activeSelf);

    }
    private void OnButtonHTPClick()
    {
        Debug.Log("Clickbutton HTP");
        SceneManager.LoadScene("MainMenu");
    }

}
