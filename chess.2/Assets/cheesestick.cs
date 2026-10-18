using UnityEngine;

public class cheesestick: MonoBehaviour
{
     // 마우스로 이 오브젝트(기물)를 클릭했을 때 자동으로 실행되는 함수
    void OnMouseDown()
    {
        // 현재 위치에서 X로 6, Y로 9 만큼 더해서 이동시킵니다.
        transform.position += new Vector3(1f, 2f, 0f);
    }
}

