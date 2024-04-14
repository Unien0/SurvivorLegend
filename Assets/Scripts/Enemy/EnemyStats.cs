using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyStats : MonoBehaviour
{
    public EnemyDataList_SO enemyDataList_SO;
    //敌人数据
    public string enemyID;
    private string enemyName;
    private Sprite enemyOnWorldSprite;
    private EnemyRace enemyType;
    private int enemyHP;
    private float enemyMoveSpeed;
    private int enemyDamage;
    private int enemyDefensive;
    private int enemyMagicDamage;
    private int enemyMagicDefensive;
    private int enemyPenetrationAbility;
    private int enemyDodgeChance;
    private int enemyAttackFrequency;//敌人攻速
    private EnemyAttackMode enemyAttackMode;
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
    private EnemyAttackMode currentAttackMode;

    public bool isDead;

    //组件
    AILerp ai;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        //获取组件
        ai = GetComponent<AILerp>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    private void OnDestroy()
    {
        
    }

    private void OnEnable()
    {

        //根据ID从enemyDataList_SO中复制敌人数据
        if (enemyDataList_SO != null && enemyDataList_SO.EnemyDetailsList != null)
        {
            foreach (var enemyDetails in enemyDataList_SO.EnemyDetailsList)
            {
                if (enemyDetails.enemyID == enemyID)
                {
                    enemyName = enemyDetails.enemyName;
                    enemyOnWorldSprite = enemyDetails.enemyOnWorldSprite;
                    enemyType = enemyDetails.enemyType;
                    enemyHP = enemyDetails.enemyHP;
                    enemyMoveSpeed = enemyDetails.enemyMoveSpeed;
                    enemyDamage = enemyDetails.enemyDamage;
                    enemyDefensive = enemyDetails.enemyDefensive;
                    enemyMagicDamage = enemyDetails.enemyMagicDamage;
                    enemyMagicDefensive = enemyDetails.enemyMagicDefensive;
                    enemyPenetrationAbility = enemyDetails.enemyPenetrationAbility;
                    enemyDodgeChance = enemyDetails.enemyDodgeChance;
                    enemyAttackFrequency = enemyDetails.enemyAttackFrequency;
                    enemyAttackMode = enemyDetails.enemyAttackMode;

                    //调用图像
                    spriteRenderer.sprite = enemyOnWorldSprite;
                }
                else
                {
                    Debug.LogWarning("j找不到相关ID");
                }
            }
        }
        else
        {
            Debug.LogWarning("敌人列表报空");
        }
    }

    private void OnDisable()
    {
        //死亡时将enemyID等数据清空
        enemyID = null;
        enemyName = null;
        enemyOnWorldSprite = null;
        enemyHP = 0;
        enemyMoveSpeed = 0f;
        enemyDamage = 0;
        enemyDefensive = 0;
        enemyMagicDamage = 0;
        enemyMagicDefensive = 0;
        enemyPenetrationAbility = 0;
        enemyDodgeChance = 0;
        enemyAttackFrequency = 0;

        isDead = false;
        gameObject.layer = 7;
    }

    void Start()
    {
        //临时数据获取
        currentHP = enemyHP;
        currentMoveSpeed = enemyMoveSpeed;
        currentDamage = enemyDamage;
        currentDefensive = enemyDefensive;
        currentMagicDamage = enemyMagicDamage;
        currentMagicDefensive = enemyMagicDefensive;
        currentPenetrationAbility = enemyPenetrationAbility;
        currentDodgeChance = enemyDodgeChance;
        currentAttackFrequency = enemyAttackFrequency;


        //出生时如果是【接近】【远程】【保持距离】这几种攻击模式的话就默认将移动开启
        if (enemyAttackMode == EnemyAttackMode.Proximity || enemyAttackMode == EnemyAttackMode.Remote || enemyAttackMode == EnemyAttackMode.KeepDistance)
        {
            ai.canMove = true;
        }
    }

    void Update()
    {
        if (!isDead)
        {
            Move();
        }
    }

    private void Move()
    {
        ai.speed = currentMoveSpeed;
    }

    /// <summary>
    /// 敌人攻击
    /// </summary>
    public void Attack()
    {
        //添加算法，计算敌人对玩家的伤害
        //算法可以使用单例或者事件返回值来获取结果
        //对玩家造成伤害后结束事件
    }


    public void TakeDamage(int dmg)
    {
        currentHP -= dmg;

        if (currentHP <= 0)
        {
            //改变个体Layer至敌人尸体栏
            gameObject.layer = 8;
            isDead = true;
            //anim.SetBool("Dead", true);
            Dead();
        }
    }

    void Dead()
    {
        if (isDead)
        {
            ai.canMove = false;
            spriteRenderer.sprite = null;

            //运行对象池回收


        }
    }

}
