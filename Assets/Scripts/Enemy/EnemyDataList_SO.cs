using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "EnemyDataList_SO", menuName = "Data_SO/EnemyList")]
[InlineEditor]
public class EnemyDataList_SO : ScriptableObject
{
    public List<EnemyDetailsList> EnemyDetailsList;
}

[System.Serializable]
public class EnemyDetailsList
{
    [FoldoutGroup("$enemyName", expanded: true)]
    [Title("敌人ID与名称")]
    public string enemyID;
    [FoldoutGroup("$enemyName", expanded: true)]
    public string enemyName;
    [FoldoutGroup("$enemyName", expanded: true)]
    public Sprite enemyOnWorldSprite;//游戏内画像
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人种族")]
    public EnemyRace enemyType;//敌人种族
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人血量")]
    public int enemyHP;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人移动速度")]
    public float enemyMoveSpeed;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人攻击力")]
    public int enemyDamage;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人防御力")]
    public int enemyDefensive;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人魔法伤害")]
    public int enemyMagicDamage;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人魔力抗性")]
    public int enemyMagicDefensive;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人护甲")]
    public ArmorType armorType;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人穿防能力")]
    public int enemyPenetrationAbility;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人闪避率")]
    public int enemyDodgeChance;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人攻击频率")]
    public int enemyAttackFrequency;
    [FoldoutGroup("$enemyName", expanded: true)]
    [Header("敌人进攻模式")]
    public EnemyAttackMode enemyAttackMode;
}
