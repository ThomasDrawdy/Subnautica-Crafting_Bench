using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BenchBehaviour : MonoBehaviour
{
   
    public Animator ani;
    public GameObject controller;
    private bool open = false;
    public GameObject spawnpoint;
    public List<GameObject> spawn;
    public Canvas canvas;
    private GameObject spawned;
    public AudioClip createAudio;
    public AudioClip openAudio;
    AudioSource audioSource;
    public ParticleSystem sparks;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && open)
        {
            Close();
        }



    }

    public void Open()
    {
        audioSource.PlayOneShot(openAudio);
        ani.SetBool("E", true);
        open = true;
        controller.GetComponent<Menu>().OpenMenu();
    }

    public void Close()
    {
        audioSource.PlayOneShot(openAudio);
        ani.SetBool("E", false);
        open = false;
        controller.GetComponent<Menu>().CloseMenu();

    }

    public void CreateObject(int item)
    {
        audioSource.PlayOneShot(createAudio);
        spawned = Instantiate(spawn[item]);
        spawned.gameObject.transform.position = spawnpoint.transform.position;
        spawned.transform.parent = spawnpoint.transform;
        ani.SetTrigger("Create");
        canvas.GetComponent<Canvas>().enabled = false;
        sparks.Play();
        Invoke("ReOpen", ani.GetCurrentAnimatorClipInfo(0).Length*2+0.6f);

    }
    public void ReOpen()
    {
        sparks.Stop();
        canvas.GetComponent<Canvas>().enabled = true;
        Destroy(spawned);
        

    }


}
