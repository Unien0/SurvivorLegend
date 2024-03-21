using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyStats : MonoBehaviour
{

    //获取玩家
    private AIDestinationSetter AISetter;

    void Start()
    {
        AISetter = GetComponent<AIDestinationSetter>();
        AISetter.target = PlayerStats.Instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
