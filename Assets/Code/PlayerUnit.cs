﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : MonoBehaviour
{
    public static int maxHealth = 6;
    public static int strength = 3;
    public static int defense = 3;
    public static int currentHealth = 6;

    public static int totalDamage = 0;


    public bool TakeDamage(int strength, int defense)
    {
        //Prevents Damage Going Negative
        if (defense / 2 >= strength)
        {
            currentHealth -= 1;
        }
        else
        {
            int damage = strength - defense / 2;
            currentHealth -= damage;
            totalDamage += damage;
        }


        if (currentHealth <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }

        
    }
  
}
