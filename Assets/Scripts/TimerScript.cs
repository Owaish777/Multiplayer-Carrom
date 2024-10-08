using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timerText;

    public float timeLeft = 15.0f;  // The time in seconds that the timer will run for
    public bool isTimerRunning; // Indicates whether the timer is currently running
    private bool isTimerSoundPlaying = false;

    void Update()
    {
        if (isTimerRunning)
        {
            timeLeft -= Time.deltaTime;  // Decrement the time left by the amount of time that has passed since the last frame
            timerText.text = Mathf.Round(timeLeft).ToString();  // Update the text to show the time left

            if (timeLeft <= 5)
            {
                timerText.color = Color.red;
                
                if (!isTimerSoundPlaying)
                {
                    // Play the AudioSource to indicate that time is running out
                    GetComponent<AudioSource>().Play();
                    isTimerSoundPlaying = true;
                }
            }

            if (timeLeft <= 0)
            {
                // Stop the AudioSource and set the timer to not running
                GetComponent<AudioSource>().Stop();
                isTimerRunning = false;
                timerText.text = "Time's Up!";
            }
        }
    }

}
