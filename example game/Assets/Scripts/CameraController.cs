//using UnityEngine;

//public class CameraController : MonoBehaviour
//{


//    Transform CamTransform;
//	public Transform Player;

//	void Start()
//	{
//		CamTransform = Camera.main.transform;
//	}

//    void Update()
//    {

//        CamTransform.position = new Vector3(CamTransform.position.x, Player.position.y,  CamTransform.position.z);
//    }

//}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX;
    private Vector3 velocity = Vector3.zero;
    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);
    }

    public void MoveToNewRoom(Transform _newroom)
    {
        currentPosX = _newroom.position.x;
    }
}