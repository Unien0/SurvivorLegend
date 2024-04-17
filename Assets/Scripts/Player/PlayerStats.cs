using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class PlayerStats : Singleton<PlayerStats>
{
    public PlayerData_SO playerData;


    //当前数据
    private int currentHP;
    private float currentMoveSpeed;
    private float currentDamage;
    private float currentDefensive;
    private float currentMagicDamage;
    private float currentMagicDefensive;
    private float currentPenetrationAbility;
    private float currentDodgeChance;
    private float currentAttackFrequency;

    public bool isDead;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = playerData.playerMaxHP;
        currentMoveSpeed = playerData.playerSpeed;
        currentDamage = playerData.aggressivity;
        currentDefensive = playerData.defensive;
        currentMagicDamage = playerData.magicDamage;
        currentMagicDefensive = playerData.magicDefensive;
        currentPenetrationAbility = playerData.basePenetrationAbility;
        currentDodgeChance = playerData.dodgeChance;
        currentAttackFrequency = playerData.attackFrequency;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerTakeDamage(int damage , float fixedPenetration, float percentPenetration)
    {
        
    }
}
