﻿using System;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public Weapon EquipedWeapon;

    public double Health;
    public const double MaxHealth = 200.22;

    public bool MenuOpened;
    public bool LockMovement;
    public bool QuickTurning;
    public bool TakingDamage;
    public bool Aiming;
    public bool Shooting;

    public void AddHealth(double value)
    {
        Health = Math.Min(MaxHealth, Health + value);
    }

    public void SetHealth(double value)
    {
        Health = value;
    }

    public HealthStatus GetHealthStatus()
    {
        if(Health == 0)
            return HealthStatus.Dead;
        if(Health <= 1)
            return HealthStatus.Special;
        if(Health <= 40)
            return HealthStatus.SpeedyBoi;
        if(Health <= 80)
            return HealthStatus.BadTummyAche;
        if(Health <= 120)
            return HealthStatus.TummyAche;
        return HealthStatus.Healthy;
    }

    public bool IsMovementPrevented()
    {
        return MenuOpened || LockMovement || TakingDamage || Shooting;
    }

    public enum HealthStatus
    {
        None = 0,
        Dead,
        Special,
        SpeedyBoi,
        BadTummyAche,
        TummyAche,
        Healthy
    }
}
