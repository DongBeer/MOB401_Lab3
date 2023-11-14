using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLoop : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Box;
    public GameObject A;
    public GameObject B;

    public float speed = 5f;
    
    private Transform currentObstacle;
    void Start()
    {
        // SpawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }
    
    void MoveObstacle()
    {
        // Di chuyển chướng ngại vật theo trục x
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Kiểm tra nếu chướng ngại vật vượt qua điểm A
        // if (transform.position.x < A.transform.position.x)
        // {
        //     // Tái tạo chướng ngại vật và đặt lại vị trí
        //     RespawnObstacle();
        // }
    }

    // void SpawnObstacle()
    // {
    //     // Tái tạo chướng ngại vật tại điểm xuất phát (điểm B)
    //     currentObstacle = Instantiate(Box, B.transform.position, Quaternion.identity).transform;
    // }
    //
    // void RespawnObstacle()
    // {
    //     // Hủy chướng ngại vật hiện tại và tái tạo nó tại điểm B
    //     Destroy(currentObstacle.gameObject);
    //     SpawnObstacle();
    // }
}
