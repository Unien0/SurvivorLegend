using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 伤害算式
/// </summary>
public class DamageCalculatorManager : Singleton<DamageCalculatorManager>
{
    //算法解释：
    //免伤率 = （防御力-固定穿透）*（1-百分比穿透）/（防御力-固定穿透）*（1-百分比穿透）+（防御力*护甲类型）
    //伤害 = 攻击力*（1-免伤率）
    //护甲类型：重甲50%	中甲100%	轻甲150%	无甲200%

    public float CalculateDamage(float attackDamage, float defense, float fixedPenetration, float percentPenetration, ArmorType armorType)
    {
        //armorDamageReduction=减伤率      fixedPenetration = 固定穿透     percentPenetration = 百分比穿透
        float armorDamageReduction = GetArmorDamageReduction(defense, fixedPenetration, percentPenetration, armorType);
        float damageTaken = attackDamage * (1 - armorDamageReduction);
        return damageTaken;
    }

    private float GetArmorDamageReduction(float defense, float fixedPenetration, float percentPenetration, ArmorType armorType)
    {
        float penetration = (defense - fixedPenetration) * (1 - percentPenetration);
        float armorDamageReduction = penetration / (defense - fixedPenetration) * (1 - percentPenetration) + (defense * GetArmorModifier(armorType));
        return armorDamageReduction;
    }

    private float GetArmorModifier(ArmorType armorType)
    {
        switch (armorType)
        {
            case ArmorType.NonArmor:
                return 2f; 
            case ArmorType.LightArmor:
                return 1.5f; 
            case ArmorType.MediumArmor:
                return 1f; 
            case ArmorType.HeavyArmor:
                return 0.5f; 
            default:
                return 0f;
        }
    }
}
