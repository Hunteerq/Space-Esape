using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public GameObject ship;
    public ScoreHandler scoreHandler;


    private string endGameScene;
    private float xPosition;
    private float halfOfShipHeight;
    private float yPosition;
    private float maxPositionHeight;
    private float moveSpeed = 400f;
    int screenTouch = 0;

    void Start()
    {
        endGameScene = "Menu";
        xPosition = ship.transform.position.x;
        halfOfShipHeight = GetComponent<SpriteRenderer>().bounds.size.y /2;
        maxPositionHeight = Screen.currentResolution.height / 2 - halfOfShipHeight;
    }

    void Update ()
    {
        if (Input.GetMouseButton(screenTouch))
        {
            HandleMousePress();
        }
      
	}

    private void HandleMousePress()
    {
        Vector2 mouseRelativePosition = MouseRelativePosition;
        moveSpeed += 0.3f;
        yPosition += GetMovement(mouseRelativePosition);
        FixedUpdate();
    }

    private Vector3 MouseRelativePosition => Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

    private float GetMovement(Vector2 mouseRelativePosition) => Time.deltaTime * moveSpeed * -Mathf.Sign(mouseRelativePosition.y);

    private void FixedUpdate()
    {
        yPosition = Mathf.Clamp(yPosition, -maxPositionHeight, maxPositionHeight);
        ship.transform.position = new Vector3(xPosition, -yPosition, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        EndGame();
    }

    private void EndGame()
    {
        PlayerPrefs.SetString("Score", scoreHandler.ScoreValue);
        SceneManager.LoadScene(endGameScene);
    }
}
