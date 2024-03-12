using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "SoundDetailsList_SO", menuName ="Sound/SoundDetailsList")]
[InlineEditor]
public class SoundDetailsList_SO : ScriptableObject
{
    public List<SoundDetails> soundDetailsList;
    public SoundDetails GetSoundDetails(SoundName name)
    {
        //使用名字查找
        return soundDetailsList.Find(s => s.soundName == name);
    }
}

[System.Serializable]
public class SoundDetails
{
    [FoldoutGroup("$注释", expanded: true)]
    public string 注释;
    [FoldoutGroup("$注释", expanded: true)]
    public SoundName soundName;
    [FoldoutGroup("$注释", expanded: true)]
    public AudioClip soundClip;
    [FoldoutGroup("$注释", expanded: true)]
    [Range(0.1f, 1.5f)]
    public float soundPitchMin=1;
    [FoldoutGroup("$注释", expanded: true)]
    [Range(0.1f, 1.5f)]
    public float soundPitchMax=1;
    [FoldoutGroup("$注释", expanded: true)]
    [Range(0.1f, 1f)]
    public float soundVolume=1;
}

public enum SoundName
{
    none,
    //音乐
    BGM1,BGM2,BGM3,BGM4,BGM5,
    //背景音
    BGS1,BGS2,BGS3,BGS4,BGS5,
    //音乐音效
    ME1,ME2,ME3,ME4,ME5,
    //音效
    //按钮
    按钮1, 按钮2, 按钮3, 按钮4, 按钮5,
    //攻击
    挥砍1,挥砍2,挥砍3,挥砍4,
    突刺1,突刺2,突刺3,突刺4,
    射击1,射击2,射击3,射击4,
    //拾取
    拾取1,拾取2,拾取3,
    //装备
    装备1,装备2,装备3,
    //行走
    砖块上行走,草地上行走,木头上行走,水面上行走,
    //回复
    回血1,回血2,强化1,强化2,
    经验获取,
    升级,
    虚弱1,虚弱2,
    //受伤
    受伤1,受伤2,受伤3,
    //死亡
    死亡1,死亡2,死亡3,

    //其他
}
