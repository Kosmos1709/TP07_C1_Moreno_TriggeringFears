using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuAccion : MonoBehaviour
{

    [SerializeField] private Button BtnStart;
    [SerializeField] private Button BtnSettings;
    [SerializeField] private Button BtnCredits;
    [SerializeField] private Button BtnBack;

    [SerializeField] private GameObject PanelVolume;
    [SerializeField] private GameObject PanelCredits;




    private void Awake()
    {
        BtnStart.onClick.AddListener(OnButtonStartClick);
        BtnSettings.onClick.AddListener(OnButtonVolumeClick);
        BtnCredits.onClick.AddListener(OnButtonCreditsClick);
        BtnBack.onClick.AddListener(OnButtonHTPClick);


    }
    private void OnDestroy()
    {
        BtnStart.onClick.RemoveAllListeners();
        BtnSettings.onClick.RemoveAllListeners();
        BtnCredits.onClick.RemoveAllListeners();
        BtnBack.onClick.RemoveAllListeners();
    }


    private void OnButtonStartClick()
    {
        SceneManager.LoadScene("Gameplay");
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
        EditorSceneManager.LoadScene("MainMenu");
    }

}
