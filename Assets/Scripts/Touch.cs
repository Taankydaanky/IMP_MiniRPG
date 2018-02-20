﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour {

    private Controls player;

    
    void Start()
    {
        player = FindObjectOfType<Controls>();
    }
    public void Jump()
    {
        player.jump = true;
    }
    public void LeftArrow()
    {
        player.moveRight = false;
        player.moveLeft = true;
    }
    public void RightArrow()
    {
        player.moveRight = true;
        player.moveLeft = false;
    }
    public void ReleaseLeftArrow()
    {
        player.moveLeft = false;
    }
    public void ReleaseRightArrow()
    {
        player.moveRight = false;

    }
}
