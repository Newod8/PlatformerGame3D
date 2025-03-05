using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 playerOffset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        playerOffset = player.transform.position - transform.position;
        transform.rotation = Quaternion.LookRotation(playerOffset);
    }
}
