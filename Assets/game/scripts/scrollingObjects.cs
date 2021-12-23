﻿using UnityEngine;
using System.Collections;

public class scrollingObjects : MonoBehaviour {

    private Rigidbody2D rb2d;
    public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (gameControl.instance.gameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
	
	}
}
