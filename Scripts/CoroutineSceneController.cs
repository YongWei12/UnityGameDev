using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineSceneController : MonoBehaviour
{
    public List<Shape> gameShapes;
    private Coroutine countToNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private IEnumerator SetShapeBlue()
    {
        Debug.Log("Start Setting Color Blue");
        foreach (Shape shape in gameShapes)
        {
            shape.SetColor(Color.blue);
            yield return new WaitForSeconds(2);
            shape.SetColor(Color.white);
        }
        yield return new WaitForSecondsRealtime(1);
        Debug.Log("I just wasted a second");
        yield return StartCoroutine(SetShapeBlue());
    }

    private IEnumerator CountToNumber(int numberToCountTo)
    {
        for(int i = 0; i< numberToCountTo; i++)
        {
            Debug.Log(i);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            countToNumber = StartCoroutine(CountToNumber(25000));
            //StartCoroutine(CountToNumber(250000));
            StartCoroutine(SetShapeBlue());
            Debug.Log("Update Finished");           
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopCoroutine(countToNumber);
        }
    }
}
