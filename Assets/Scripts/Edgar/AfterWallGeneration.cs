using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AfterWallGeneration : MonoBehaviour
{
    private void Awake()
    {
        EventCenter.AddListener(EventTypeI.AfterWall, AfterWall);
    }

    private void OnDestroy()
    {
        EventCenter.RemoveListener(EventTypeI.AfterWall, AfterWall);
    }

    void AfterWall()
    {
        //var graphToScan = AstarPath.active.data.gridGraph;
        //AstarPath.active.Scan(graphToScan);
        AstarPath.active.Scan();
        Debug.Log("导航更新");
    }

    void AddToQueue()
    {

    }


}
