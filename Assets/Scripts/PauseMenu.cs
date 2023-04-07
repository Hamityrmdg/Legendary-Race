using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool MenuAcKapa;
    void Start()
    {
        pauseMenu = GameObject.FindWithTag("PauseMenu");
    }
    void oyunDurdur ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuAcKapa = !MenuAcKapa;
        }
    }
    private void Update()
    {
        if (MenuAcKapa)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(MenuAcKapa);
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(MenuAcKapa);
        }
        oyunDurdur();
    }
    public void Devam()
    {
        Time.timeScale = 1;
        MenuAcKapa = !MenuAcKapa;
        pauseMenu.SetActive(MenuAcKapa);
    }
}
