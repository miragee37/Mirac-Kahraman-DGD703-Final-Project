using UnityEngine;

public class SettingsController : MonoBehaviour
{
    public GameObject settingsMenu;
    public GameObject mainScreen; // MainMenuGroup objesi

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (settingsMenu != null && settingsMenu.activeSelf)
            {
                CloseSettings();
            }
        }
    }

    public void OpenSettings()
    {
        if (settingsMenu != null)
            settingsMenu.SetActive(true);

        if (mainScreen != null)
            mainScreen.SetActive(false);
    }

    public void CloseSettings()
    {
        if (settingsMenu != null)
            settingsMenu.SetActive(false);

        if (mainScreen != null)
            mainScreen.SetActive(true);
    }
}