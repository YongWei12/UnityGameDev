using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        SetColor(Color.cyan);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        //this will the the x movement when left and right arrow are pressed
        float horizontalMovement = Input.GetAxis("Horizontal");

        if(Mathf.Abs(horizontalMovement)> Mathf.Epsilon)
        {
            horizontalMovement = horizontalMovement * Time.deltaTime;
            horizontalMovement += transform.position.x;

            transform.position = new Vector2(horizontalMovement, transform.position.y);
        }
    }
}
