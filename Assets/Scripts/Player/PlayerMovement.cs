using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public PlayerData_SO playerData;
    private Rigidbody2D rb;
    private Vector2 movement;

    private void Awake()
    {
        EventCenter.AddListener<Vector3>(EventTypeI.positionInitialization, PositionInitialization);
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnDestroy()
    {
        EventCenter.RemoveListener<Vector3>(EventTypeI.positionInitialization, PositionInitialization);
    }

    void Start()
    {
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        rb.velocity = movement.normalized * playerData.currentSpeed;
        if (movement.x !=0 || movement.y != 0)
        {
            //对应脚下的内容播放声音
        }
    }

    void PositionInitialization(Vector3 pos)
    {
        this.transform.position = pos;
    }

}
