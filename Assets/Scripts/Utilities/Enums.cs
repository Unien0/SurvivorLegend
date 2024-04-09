//枚举相关


////玩家相关

//玩家角色
public enum PlayerCharacter
{

} 

//攻击类型
public enum AttackType
{
    BluntAttack,SharpAttack,MagicAttack
}

//护甲类型
public enum ArmorType
{
    HeavyArmor,MediumArmor, LightArmor,NonArmor
}

//武器类型
public enum WeaponType
{
    Dagger, Sword, Sabre, Axe, Staff, Stick, Hammer, MeteorHammer, Polearms, Whip, Sickle, 
    Shield,
    Bow, Crossbow,
    Wand, StatuteBook
}

//装备类型
public enum EquipmentType
{
    Helmet, Glove, BodyArmor, Pants, Shoe
}

//消耗品类型
public enum ConsumableTypes
{
    Potion, Missile,Gemstone, Scroll
}


////敌人相关////

//敌人种族
public enum EnemyRace
{
    Undead, Plant, Animal, Humanoid, Creature, Elemental, Demon
}

//敌人攻击模式
public enum EnemyAttackMode
{
    Proximity, Remote, Flee, KeepDistance
}