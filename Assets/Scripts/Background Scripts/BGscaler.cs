﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;

        float width = sr.sprite.bounds.size.x;

        float worldHeight = Camera.main.orthographicSize * 2f;
        float worldWidth = worldHeight / Screen.height * Screen.width;

        tempScale.x = worldWidth / width;
        transform.localScale = tempScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
