using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "WeaponData_SO", menuName = "Data_SO/WeaponList")]
[InlineEditor]
public class WeaponData_SO : ScriptableObject
{
    public List<WeaponDetailsList> WeaponDetailsList;
}

[System.Serializable]
public class WeaponDetailsList
{
    [FoldoutGroup("$weaponName", expanded: true)]
    [Title("武器ID与名称")]
    public string weaponID;
    [FoldoutGroup("$weaponName", expanded: true)]
    public string weaponName;
    [FoldoutGroup("$weaponName", expanded: true)]
    public Sprite weaponOnWorldSprite;//游戏内画像
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器类型")]
    public WeaponType weaponType;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器攻击力")]
    public int weaponDamage;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器防御力")]
    public int weaponDefensive;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器魔法伤害")]
    public int weaponMagicDamage;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器魔力抗性")]
    public int weaponMagicDefensive;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器固定穿防能力")]
    public int weaponFixedPenetrationAbility;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器百分比穿防能力")]
    public int weaponPercentagePenetrationAbility;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器闪避率")]
    public int weaponDodgeChance;
    [FoldoutGroup("$weaponName", expanded: true)]
    [Header("武器攻击频率")]
    public int weaponAttackFrequency;

}
