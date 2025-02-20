using UnityEngine;

public class animationtimer : MonoBehaviour
{
    // The animation to play
    public Animator animator;

    // Time in seconds to wait before playing the animation
    public float delayTime = 2f;

    // Name of the animation state to play
    public string animationStateName = "YourAnimationStateName";

    private void Start()
    {
        // Start the delay before playing the animation
        Invoke("PlayAnimation", delayTime);
    }

    // This method will play the animation
    private void PlayAnimation()
    {
        if (animator != null)
        {
            animator.Play(animationStateName);
        }
        else
        {
            Debug.LogError("Animator not assigned!");
        }
    }
}