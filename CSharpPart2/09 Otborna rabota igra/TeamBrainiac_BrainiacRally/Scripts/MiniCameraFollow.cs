using UnityEngine;
public class MiniCameraFollow : MonoBehaviour
{

    public Transform target;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
    }
}