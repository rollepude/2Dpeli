using UnityEngine;

public class CameraController : MonoBehaviour
{


    Transform CamTransform;
	public Transform Player;

	void Start()
	{
		CamTransform = Camera.main.transform;
	}

    void Update()
    {

        CamTransform.position = new Vector3(CamTransform.position.x, Player.position.y,  CamTransform.position.z);
    }

}