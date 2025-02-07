﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RougeKnightHealth : MonoBehaviour
{
    public int health = 500;

    public GameObject deathEffect;
    public GameObject portal;

    public bool isInvulnerable = false;

    public void TakeDamage(int damage)
    {
        if (isInvulnerable)
            return;

        health -= damage;

        if (health <= 0)
        {
            Die();
            SpawnPortal();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void SpawnPortal()
    {
        Instantiate(portal, transform.position, Quaternion.identity);
    }
}
