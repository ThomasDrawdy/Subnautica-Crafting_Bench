using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenchBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator ani;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {

        ani.SetBool("E", true);

    }

}
