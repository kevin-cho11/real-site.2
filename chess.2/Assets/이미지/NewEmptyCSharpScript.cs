
using UnityEngine;

public class MapoTofuMove : MonoBehaviour
{
    private bool isSelected = false;

    // 마파두부를 클릭하면 선택
    private void OnMouseDown()
    {
        isSelected = true;
        Debug.Log("마파두부 선택! Q, W, E, A, S, D, Z, X 키로 이동하세요.");
    }

    private void Update()
    {
        if (!isSelected) return;

        Vector3 moveDelta = Vector3.zero;
        bool hasMoved = false;

        // 상하좌우 2칸 이동 (칸 간격 1.5 기준)
        // Q: 왼쪽 위 대각선 1칸
        if (Input.GetKeyDown(KeyCode.Q))
        {
            moveDelta = new Vector3(-1.5f, 1.5f, 0f);
            hasMoved = true;
        }
        // W: 위로 2칸
        else if (Input.GetKeyDown(KeyCode.W))
        {
            moveDelta = new Vector3(0f, 3f, 0f);
            hasMoved = true;
        }
        // E: 오른쪽 위 대각선 1칸
        else if (Input.GetKeyDown(KeyCode.E))
        {
            moveDelta = new Vector3(1.5f, 1.5f, 0f);
            hasMoved = true;
        }
        // A: 왼쪽으로 2칸
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveDelta = new Vector3(-3f, 0f, 0f);
            hasMoved = true;
        }
        // D: 오른쪽으로 2칸
        else if (Input.GetKeyDown(KeyCode.D))
        {
            moveDelta = new Vector3(3f, 0f, 0f);
            hasMoved = true;
        }
        // Z: 왼쪽 아래 대각선 1칸
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            moveDelta = new Vector3(-1.5f, -1.5f, 0f);
            hasMoved = true;
        }
        // X: 아래로 2칸
        else if (Input.GetKeyDown(KeyCode.X))
        {
            moveDelta = new Vector3(0f, -3f, 0f);
            hasMoved = true;
        }
        // C: 오른쪽 아래 대각선 1칸
        else if (Input.GetKeyDown(KeyCode.C))
        {
            moveDelta = new Vector3(1.5f, -1.5f, 0f);
            hasMoved = true;
        }

        if (hasMoved)
        {
            transform.position += moveDelta;
            Debug.Log("마파두부 이동 완료: " + moveDelta);
            isSelected = false;
        }
    }
}
