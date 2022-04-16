using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public enum ClickTypeEvent
{
    AttackClick,
    MenuButton
}


public enum Attacking
{
    Player,
    Enemy
}

//нужно вынести енамы

public struct AttackComponent
{
    public Attacking Attacking;
    public float DamageAmount;
}


