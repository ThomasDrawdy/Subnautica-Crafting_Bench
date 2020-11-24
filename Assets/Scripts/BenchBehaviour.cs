using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchBehaviour : MonoBehaviour
{
   
    public Animator ani;
    public GameObject controller;
    private bool open = false;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && open)
        {
            Close();
        }
    }

    public void Open()
    {

        ani.SetBool("E", true);
        open = true;
        controller.GetComponent<Menu>().OpenMenu();
    }

    public void Close()
    {
        ani.SetBool("E", false);
        controller.GetComponent<Menu>().CloseMenu();

    }

}
