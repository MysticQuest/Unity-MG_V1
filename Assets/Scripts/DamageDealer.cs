﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{

    public int damage = 100;

    public int getDamaged()
    {
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
