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
    public EnemyCategory enemyType;
    [FoldoutGroup("$enemyName", expanded: true)]
    public int enemyHP;
    [FoldoutGroup("$enemyName", expanded: true)]
    public float enemyMoveSpeed;
    [FoldoutGroup("$enemyName", expanded: true)]
    public int enemyDamage;

}
