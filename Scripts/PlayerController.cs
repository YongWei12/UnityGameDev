using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Shape
{
    private GameSceneController gameSceneController;
    public ProjectileController projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        gameSceneController = FindObjectOfType<GameSceneController>();
        SetColor(Color.cyan);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireProjectile();
        }
    }

    private void MovePlayer()
    {
        //this will the the x movement when left and right arrow are pressed
        float horizontalMovement = Input.GetAxis("Horizontal");

        if(Mathf.Abs(horizontalMovement)> Mathf.Epsilon)
        {
            horizontalMovement = horizontalMovement * Time.deltaTime * gameSceneController.playerSpeed;
            horizontalMovement += transform.position.x;

            transform.position = new Vector2(horizontalMovement, transform.position.y);
        }
    }

    private void FireProjectile()
    {
        Vector2 spawnPosition = transform.position;

        ProjectileController projectile =
            Instantiate(projectilePrefab, spawnPosition, Quaternion.identity);

        projectile.projectileSpeed = 2;
        projectile.projectileDirection = Vector2.up;
    }
}
