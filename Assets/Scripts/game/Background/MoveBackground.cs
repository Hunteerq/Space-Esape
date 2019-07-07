using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{


    private float movement = 0.01f;
    private const float moveSpeed = 0.000001f;

    private Renderer _renderer;

    // Use this for initialization
    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movement += moveSpeed;
        Move();    
    }

    private void Move()
    {
        Vector2 offset = new Vector2(Time.time * movement, 0);
        _renderer.material.mainTextureOffset = offset;
    }
}
