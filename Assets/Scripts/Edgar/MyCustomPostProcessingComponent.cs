using Edgar.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class MyCustomPostProcessingComponent : DungeonGeneratorPostProcessingComponentGrid2D
    {
        public override void Run(DungeonGeneratorLevelGrid2D level)
        {
        // Implement the logic here
        EventCenter.Broadcast(EventTypeI.DungeonGeneratorStart);
        Debug.Log("发出指令");

    }
  }

