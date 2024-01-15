using UnityEngine;

public class BallReset : MonoBehaviour
{
    public GameObject ball; // Reference to the ball object
    public GameObject referenceObject; // Reference to the GameObject whose position will be used for reset
    public Rigidbody ballRigidbody; // Reference to the ball's Rigidbody component

    private Vector3 startingPosition; // Variable to store the starting position of the ball
    private SaveLoadCounter saveLoadCounter; // Reference to the SaveLoadCounter script

    void Start()
    {
        // Store the initial starting position of the ball
        startingPosition = referenceObject.transform.position;
        saveLoadCounter = FindObjectOfType<SaveLoadCounter>();

    }

    public void ResetBallPosition()
    {
        if (referenceObject != null)
        {
            // Reset the ball's position to match the reference object's position
            ball.transform.position = referenceObject.transform.position;
            saveLoadCounter.ResetCounters();

        }
        else
        {
            Debug.LogWarning("Reference object is not assigned.");
            // Reset the ball's position to the stored starting position if referenceObject is not assigned
            ball.transform.position = startingPosition;
            saveLoadCounter.ResetCounters();

        }
          if (ballRigidbody != null)
        {
            ballRigidbody.constraints = RigidbodyConstraints.None;
        }
    }
}
