using UnityEngine;

public class SaveLoadObjectPositions : MonoBehaviour
{
    public GameObject ball; // Reference to the ball object
    public GameObject targetObject; // Reference to another GameObject to save/load positions

    private Vector3 ballStartPosition; // Store the initial position of the ball
    private Vector3 objectStartPosition; // Store the initial position of the targetObject
    public Rigidbody ballRigidbody; // Reference to the ball's Rigidbody component

    private SaveLoadCounter saveLoadCounter; // Reference to the SaveLoadCounter script

    void Start()
    {
        // Store the initial positions of the ball and targetObject
        ballStartPosition = ball.transform.position;
        objectStartPosition = targetObject.transform.position;
        saveLoadCounter = FindObjectOfType<SaveLoadCounter>();

    }

    // Function to save positions
    public void SavePositions()
    {
        // Save the ball's position to targetObject's position
        targetObject.transform.position = ball.transform.position;
        if (saveLoadCounter != null)
        {
            saveLoadCounter.IncrementSaveCounter();
        }
        
        
        Debug.Log("Positions saved!");
    }

    // Function to load positions
    public void LoadPositions()
    {
        // Load the ball's position from targetObject's position
        ball.transform.position = targetObject.transform.position;

        // Load the targetObject's position from ball's initial position
        if (saveLoadCounter != null)
        {
            saveLoadCounter.IncrementLoadCounter();
        }
          if (ballRigidbody != null)
        {
            ballRigidbody.constraints = RigidbodyConstraints.None;
        }
        Debug.Log("Positions loaded and swapped!");
    }
}
