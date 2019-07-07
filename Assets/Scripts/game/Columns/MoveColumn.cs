using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class MoveColumn : MonoBehaviour
{

    public GameObject column;

    private float moveSpeed = 10f;
    private float newXPosition;
    private float yPosition;
    private float endPosition;


    void Start()
    {
        yPosition = column.transform.position.y;
        endPosition = -Screen.currentResolution.width / 2;
    }

    void Update()
    {
        newXPosition = column.transform.position.x - moveSpeed;
        column.transform.position = new Vector3(newXPosition, yPosition, 0.0f);
        CheckIfColumnShouldBeDeleted();
    }

    private void CheckIfColumnShouldBeDeleted()
    {
        if (column.transform.position.x <= endPosition)
        {
            Destroy(column);
            DestroyScript();
        }
    }

    private void DestroyScript()
    {
        Destroy(this);
    }
}
