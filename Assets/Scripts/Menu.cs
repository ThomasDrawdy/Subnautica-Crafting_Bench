using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject menu;
    private bool menuOpen = false;
    public GameObject bench;

    void Start()
    {
      //  Cursor.lockState = CursorLockMode.Locked;
    }

    public void OpenMenu()
    {
        menu.SetActive(true);
        player.GetComponent<PlayerBehaviour>().CursorActive();
    }
    public void CloseMenu()
    {
        menu.SetActive(false);
        player.GetComponent<PlayerBehaviour>().CursorInactive();
        
    }
}
