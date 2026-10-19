
using UnityEngine;

public class InfiniteDirectionMove : MonoBehaviour
{
    private bool isSelected = false;

    // 1. 오브젝트를 마우스로 클릭했을 때 호출됩니다.
    private void OnMouseDown()
    {
        isSelected = true;
        Debug.Log("오브젝트가 선택되었습니다. Q, W, A, S 중 하나를 누르세요.");
    }

    // 2. 매 프레임마다 키 입력 감지
    private void Update()
    {
        // 오브젝트가 선택되지 않았다면 키 입력을 무시합니다.
        if (!isSelected) return;

        Vector3 moveDelta = Vector3.zero;
        bool hasMoved = false;

        // Q: -x로 1, y로 1
        if (Input.GetKeyDown(KeyCode.Q))
        {
            moveDelta = new Vector3(-1.5f, 1.5f, 0f);
            hasMoved = true;
        }
        // W: x로 1, y로 1
        else if (Input.GetKeyDown(KeyCode.W))
        {
            moveDelta = new Vector3(1.5f, 1.5f, 0f);
            hasMoved = true;
        }
        // A: -x로 1, -y로 1
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveDelta = new Vector3(-1.5f, -1.5f, 0f);
            hasMoved = true;
        }
        // S: x로 1, -y로 1
        else if (Input.GetKeyDown(KeyCode.S))
        {
            moveDelta = new Vector3(1.5f, -1.5f, 0f);
            hasMoved = true;
        }

        // 키가 입력되었다면 위치를 이동시키고, 다시 대기 상태로 돌아갑니다.
        if (hasMoved)
        {
            transform.position += moveDelta;
            Debug.Log($"이동 완료: {moveDelta} / 다시 클릭을 기다립니다.");

            // 스크립트를 끄는 대신 선택 상태를 해제하여 무한 반복이 가능하게 합니다.
            isSelected = false;
        }
    }
}