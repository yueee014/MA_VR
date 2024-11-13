using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//using TMPro.Examples;

public class BallCounter : MonoBehaviour
{
    private int NumberOfBall;
    public TextMeshPro ballCounterText;

    public AudioClip scoreSound;      // Assign your sound clip in the Inspector
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider possibaleBall)
    {
        if (possibaleBall.gameObject.tag == "Balls")
        {
            audioSource.Play();
            NumberOfBall++;
            Destroy(possibaleBall.gameObject);
            Debug.Log("Ball Enter total balls = " + NumberOfBall);
            ballCounterText.text = "Balls: " + NumberOfBall;
            ballCounterText.color = new Color(
                Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)
            );
        }
    }
}
