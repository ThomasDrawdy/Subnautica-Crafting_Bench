using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBehaviour : MonoBehaviour
{


    private List<GameObject> tierOne = new List<GameObject>();
    private List<GameObject> tierTwo = new List<GameObject>();


    private void Start()
    {

        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Tier1")) 
        { 
            tierOne.Add(g);
        }
        foreach (GameObject g in GameObject.FindGameObjectsWithTag("Tier2"))
        {
            tierTwo.Add(g);
        }

        foreach (GameObject g in tierOne)
        {
            g.SetActive(false);
        }
        foreach (GameObject g in tierTwo)
        {
            g.SetActive(false);
        }
        this.gameObject.SetActive(false);
    }
    
    public void Base(int side)
    {
        foreach(GameObject g in tierOne)
        {
            g.SetActive(false);
        }
        foreach(GameObject g in tierTwo)
        {
            g.SetActive(false);
        }
        tierOne[side].SetActive(true);
    }

    public void TierOne(int side)
    {
        foreach(GameObject g in tierTwo)
        {
            g.SetActive(false);
        }
        tierTwo[side].SetActive(true);
    }

    
}
