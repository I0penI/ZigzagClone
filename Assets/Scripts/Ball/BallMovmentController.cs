using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovmentController : MonoBehaviour
{
    [SerializeField] 
    private BallDataTransmiter ballDataTransmiter;

    [SerializeField]
    private float ballMoveSpeed;

    private void Update()
    {
        SetBallMovment();
    }
    private void SetBallMovment()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * ballMoveSpeed * Time.deltaTime;
    }
}
