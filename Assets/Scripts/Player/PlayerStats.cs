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
    private int currentDamage;
    private int currentDefensive;
    private int currentMagicDamage;
    private int currentMagicDefensive;
    private ArmorType armorType;
    private float currentPenetrationAbility;
    private float currentDodgeChance;
    private float currentAttackFrequency;

    public bool isDead;
    public bool canMove;
    public bool canAttack;

    void Start()
    {
        currentHP = playerData.playerMaxHP;
        currentMoveSpeed = playerData.playerSpeed;
        currentDamage = playerData.aggressivity;
        currentDefensive = playerData.defensive;
        currentMagicDamage = playerData.magicDamage;
        currentMagicDefensive = playerData.magicDefensive;
        armorType = playerData.armorType;
        currentPenetrationAbility = playerData.basePenetrationAbility;
        currentDodgeChance = playerData.dodgeChance;
        currentAttackFrequency = playerData.attackFrequency;
    }

    void Update()
    {
        
    }

    /// <summary>
    /// 玩家受伤
    /// </summary>
    /// <param name="damage"></param>
    /// <param name="fixedPenetration"></param>
    /// <param name="percentPenetration"></param>
    public void PlayerTakeDamage(int damage , float fixedPenetration, float percentPenetration)
    {
        //调用单例进行伤害计算
        int dmg = (int)DamageCalculatorManager.Instance.CalculateDamage(damage, currentMagicDefensive, fixedPenetration, percentPenetration, armorType);

        currentHP -= dmg;

        if (currentHP <= 0)
        {
            isDead = true;
        }
    }
}
