using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleScript : MonoBehaviour
{
    public int numberToShow;

    // Start is called before the first frame update
    void Start()
    {
        SayHelloWorld();
    }

    private void SayHelloWorld()
    {
        for(int i =0; i<numberToShow; i++)
        {
            Debug.Log("Hello World");
        }
    }


}
