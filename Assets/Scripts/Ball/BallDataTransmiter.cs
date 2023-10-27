using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDataTransmiter : MonoBehaviour
{
    [SerializeField] 
    private BallInputController ballInputController;

    void Start()
    {
        
    }

    public Vector3 GetBallDirection()
    {
        return ballInputController.ballDirection;
    }
}
