using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "PlayerData_SO", menuName = "Data_SO/Player")]
public class PlayerData_SO : ScriptableObject
{
    [Title("玩家ID与名称")]
    public int PlayerID;
    public string playerName;//名称
    public Sprite playerIcon;//图标
    public Sprite playerOnWorldSprite;//游戏内画像，身体部分
    [Header("角色说明")]
    [LabelWidth(100)]
    [TextArea] public string playerDescription;//介绍
    [Header("持有金")]
    public int playerMoney;
    [Space(10)]

    [Header("玩家属性")]
    //经验与等级
    public int playerLevel;
    public int playerExperience;
    //移动
    public float playerSpeed;
    public float currentSpeed;
    //生命
    public int playerMaxHP;//最大血量
    public int currentHP;

    public int aggressivity;//攻击力
    public int defensive;//防御力
    public int magicDamage;//魔法攻击
    public int magicDefensive;//魔法抗性
    public float criticalHitRate;//暴击率
    public float basePenetrationAbility;//基础穿防能力
    public float dodgeChance;//闪避率

    public int playerPower;//力量
    public int playerTechnique;//技巧
    public int playeRagile;//敏捷
    public int playerConstitution;//体质
    public int playerIntelligence;//智力


}
