using UnityEngine;
using TMPro;

public class GameStatusWon : MonoBehaviour
{
    public TextMeshProUGUI gameStatusText; // Reference to the UI Text object
    public Rigidbody sphereRigidbody; // Reference to the sphere's Rigidbody component

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            // Update UI text to display "Game Won" when the ball touches the winning zone
            gameStatusText.text = "Game Won!";
            Debug.Log("Congratulations! You won the game!");

            // Stop the sphere from moving by freezing its Rigidbody
            FreezeSphere();

            // Perform additional actions for winning the game

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
