using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player_x;
    public float start,end;
    public CinemachineVirtualCamera virtualCamera;
    void Start()
    {
         if (virtualCamera == null)
        {
            Debug.LogError("Virtual Camera not assigned!");
            return;
        }
                SetCameraPosition();

    }

    // Update is called once per frame
    void Update()
    {
       SetCameraPosition();
    }
    void SetCameraPosition()
    {
        var player = player_x.transform.position.x;

        // Clamp player position to the specified range
        float clampedPlayerX = Mathf.Clamp(player, start, end);

        // Set the position of the virtual camera
        virtualCamera.transform.position = new Vector3(clampedPlayerX, 0, 0);
    }
}
