﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        var oldY = this.gameObject.transform.localPosition;
        oldY.y = oldY.y - 3 * Time.deltaTime;
        this.gameObject.transform.localPosition = oldY;
    }
}
