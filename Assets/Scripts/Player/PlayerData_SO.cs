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
    public Sprite playerOnWorldSprite;//游戏内画像
    [Header("角色说明")]
    [LabelWidth(100)]
    [TextArea] public string playerDescription;//介绍
    [Header("持有金")]
    public int playerMoney;
    [Space(10)]

    [Header("玩家属性")]
    public int playerMaxHP;//最大血量
    public int currentHP;
    public float playerSpeed;
    public float currentSpeed;

}
