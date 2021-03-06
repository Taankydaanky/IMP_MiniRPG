﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eventsystem : MonoBehaviour {

    public static Eventsystem INSTANCE;

    private void Awake()
    {
        if (INSTANCE == null)
        {
            INSTANCE = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }
}
