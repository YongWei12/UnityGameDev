using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericList : MonoBehaviour
{
    public List<Shape> gameShapes;
    public Dictionary<string, Shape> shapeDictionary;
    public Queue<Shape> shapeQueue;
    public Stack<Shape> shapeStack;

    // Start is called before the first frame update
    void Start()
    {
        shapeStack = new Stack<Shape>();
        shapeQueue = new Queue<Shape>();
        shapeDictionary = new Dictionary<string, Shape>();

        foreach (Shape shape in gameShapes)
        {
            shapeDictionary.Add(shape.Name, shape);
        }

        shapeQueue.Enqueue(shapeDictionary["Triangle"]);
        shapeQueue.Enqueue(shapeDictionary["Square"]);
        shapeQueue.Enqueue(shapeDictionary["Circle"]);
        shapeQueue.Enqueue(shapeDictionary["Octagon"]);

        shapeStack.Push(shapeDictionary["Triangle"]);
        shapeStack.Push(shapeDictionary["Square"]);
        shapeStack.Push(shapeDictionary["Circle"]);
        shapeStack.Push(shapeDictionary["Octagon"]);



    }

    //Method to set selected shape red
    private void SetRedByName(string shapeName)
    {
        shapeDictionary[shapeName].SetColor(Color.red);
    }

    private void DictionaryExample()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SetRedByName("Square");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SetRedByName("Circle");
        }
    }

    private void DeQueueExample()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shapeQueue.Dequeue().SetColor(Color.blue);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            shapeStack.Pop().SetColor(Color.blue);
        }
    }

}