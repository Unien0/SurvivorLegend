using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPositionInitialization : MonoBehaviour
{
    private Vector3 isTransform;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        isTransform = this.gameObject.transform.position;
        //将位置传给玩家
        EventCenter.Broadcast<Vector3>(EventTypeI.positionInitialization, isTransform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
