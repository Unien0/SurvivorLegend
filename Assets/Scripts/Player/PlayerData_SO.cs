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
    [Header("金钱获取倍率")]
    public float moneyAcquisitionRate;

    [FoldoutGroup("等级相关")]
    [Header("等级")]
    //经验与等级
    public int playerLevel;
    [FoldoutGroup("等级相关")]
    [Header("升级所需")]
    public int levelUpExperience;
    [FoldoutGroup("等级相关")]
    [Header("当前经验")]
    public int currentExperience;
    [FoldoutGroup("等级相关")]
    [Header("经验获取倍率")]
    public float experienceAcquisitionRate;


    [FoldoutGroup("基础属性")]
    [Header("最大血量")]
    //生命
    public int playerMaxHP;//最大血量
    [FoldoutGroup("基础属性")]
    [Header("当前血量")]
    public int currentHP;
    [FoldoutGroup("基础属性")]
    [Header("速度")]
    //移动
    public float playerSpeed;
    [FoldoutGroup("基础属性")]
    [Header("当前速度")]
    public float currentSpeed;
    

    [FoldoutGroup("基础属性")]
    [Header("攻击力")]
    public int aggressivity;//攻击力
    [FoldoutGroup("基础属性")]
    [Header("防御力")]
    public int defensive;//防御力
    [FoldoutGroup("基础属性")]
    [Header("魔法攻击")]
    public int magicDamage;//魔法攻击
    [FoldoutGroup("基础属性")]
    [Header("魔法抗性")]
    public int magicDefensive;//魔法抗性
    [FoldoutGroup("基础属性")]
    [Header("暴击率")]
    public float criticalHitRate;//暴击率
    [FoldoutGroup("基础属性")]
    [Header("基础穿防能力")]
    public float basePenetrationAbility;//基础穿防能力
    [FoldoutGroup("基础属性")]
    [Header("闪避率")]
    public float dodgeChance;//闪避率
    [FoldoutGroup("基础属性")]
    [Header("攻击速度")]
    public float attackFrequency;//攻击速度

    [FoldoutGroup("五维面板")]
    [Header("力量")]
    public int playerPower;//力量
    [FoldoutGroup("五维面板")]
    [Header("技巧")]
    public int playerTechnique;//技巧
    [FoldoutGroup("五维面板")]
    [Header("敏捷")]
    public int playeRagile;//敏捷
    [FoldoutGroup("五维面板")]
    [Header("体质")]
    public int playerConstitution;//体质
    [FoldoutGroup("五维面板")]
    [Header("智力")]
    public int playerIntelligence;//智力


}
