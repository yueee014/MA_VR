using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCreator : MonoBehaviour
{
    public GameObject ball;
    public Transform hand;

    public void SpawnBalls()
    {
        Instantiate(ball, hand.position, hand.rotation);
        //CreateObjectAtPoint(ball, hand);
    }


}
