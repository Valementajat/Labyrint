using UnityEngine;
using TMPro;

public class GameStatusLose : MonoBehaviour
{
    public TextMeshProUGUI gameStatusText; // Reference to the UI Text object
    public Rigidbody sphereRigidbody; // Reference to the sphere's Rigidbody component

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            // Update UI text to display "Game Over" when the ball touches the game-over zone
            gameStatusText.text = "Game Over!";
            Debug.Log("Game Over! The ball touched the game-over zone.");

            // Stop the sphere from moving by freezing its Rigidbody
            FreezeSphere();

            // Perform additional game-over logic if needed
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Reset UI text to empty when the ball exits any trigger zone
        gameStatusText.text = "";
    }

    // Function to freeze the sphere's Rigidbody
    private void FreezeSphere()
    {
        if (sphereRigidbody != null)
        {
            sphereRigidbody.velocity = Vector3.zero;
            sphereRigidbody.angularVelocity = Vector3.zero;
            sphereRigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}
