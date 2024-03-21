using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

/// <summary>
/// 获取目标—玩家，并调整朝向
/// </summary>
public class GetTargetPlayer : MonoBehaviour
{
    [Header("翻转图像：头朝左时请启用")]
    public bool rolloverImage;
    private AIDestinationSetter AISetter;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        AISetter = GetComponent<AIDestinationSetter>();
        AISetter.target = PlayerStats.Instance.transform;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // 计算敌人指向玩家的方向
        Vector2 directionToPlayer = PlayerStats.Instance.transform.position - transform.position;
        if (rolloverImage)
        {
            // 根据方向调整敌人的朝向
            if (directionToPlayer.x < 0)
            {
                spriteRenderer.flipX = false;
            }
            else
            {
                spriteRenderer.flipX = true;
            }
        }
        else
        {
            // 根据方向调整敌人的朝向
            if (directionToPlayer.x < 0)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }
        
    }
}
