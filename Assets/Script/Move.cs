using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float moveSpeed = 5f;  // 플레이어 이동 속도

    // Update is called once per frame
    void Update()
    {
        // 상하좌우 이동을 처리합니다.
        float horizontalInput = Input.GetAxisRaw("Horizontal");  // 좌우 이동 값 (-1: 왼쪽, 0: 정지, 1: 오른쪽)
        float verticalInput = Input.GetAxisRaw("Vertical");  // 상하 이동 값 (-1: 아래쪽, 0: 정지, 1: 위쪽)

        // 이동 방향 벡터를 계산합니다.
        Vector2 moveDirection = new Vector2(horizontalInput, verticalInput).normalized;

        // 이동 방향에 따라 플레이어를 이동시킵니다.
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }
}
