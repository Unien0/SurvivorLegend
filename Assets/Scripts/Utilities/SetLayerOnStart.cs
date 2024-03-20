using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLayerOnStart : MonoBehaviour
{
    public string generatedLevelName = "Generated Level"; // Generated Level的名称
    public string tilemapsName = "Tilemaps"; // Tilemaps的名称
    public string wallsName = "Walls"; // Walls的名称
    public string newLayerName = "Wall"; // 新的层级名称
    public bool isChange;

    private void Update()
    {
        if (!isChange)
        {
            // 根据名称查找Generated Level对象
            GameObject generatedLevelObject = GameObject.Find(generatedLevelName);

            if (generatedLevelObject != null)
            {
                // 在Generated Level对象下查找Tilemaps子物体
                Transform tilemapsTransform = generatedLevelObject.transform.Find(tilemapsName);

                if (tilemapsTransform != null)
                {
                    // 在Tilemaps子物体下查找Walls子物体
                    Transform wallsTransform = tilemapsTransform.Find(wallsName);

                    if (wallsTransform != null)
                    {
                        // 将Walls子物体的层级设置为新的层级
                        wallsTransform.gameObject.layer = LayerMask.NameToLayer(newLayerName);
                    }
                    else
                    {
                        Debug.LogError("Walls子物体未找到，请确保名称设置正确。");
                    }
                }
                else
                {
                    Debug.LogError("Tilemaps子物体未找到，请确保名称设置正确。");
                }
            }
            else
            {
                Debug.LogError("Generated Level对象未找到，请确保名称设置正确。");
            }
        }
        isChange = true;
    }
        
}
