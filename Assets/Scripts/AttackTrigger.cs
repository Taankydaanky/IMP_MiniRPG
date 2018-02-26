﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour {

    public int dmg = 1;
    
    void OnTriggerEnter2D (Collider2D collider)
    {
        if (collider.isTrigger != true && collider.CompareTag("Enemy"))
        {
            collider.SendMessageUpwards("TakeDamage", dmg);
            Debug.Log(dmg);
        }
    }
}
