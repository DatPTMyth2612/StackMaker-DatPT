using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject panelLS;
    [SerializeField] private GameObject panelMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ActiveLS()
    {
        panelLS.SetActive(true);
        panelMenu.SetActive(false);
    }
    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
