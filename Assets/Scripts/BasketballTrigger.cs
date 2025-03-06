using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BasketballTrigger : MonoBehaviour
{
    public ParticleSystem ps;
    public int points = 0;

    public TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = "Score: " + points;
    }

    private void OnTriggerEnter(Collider other)
    {
       ps.Play();
       points++;
    }

    private void OnTriggerExit(Collider other)
    {
        ps.Stop();
    }
}
