using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SaveLoadCounter : MonoBehaviour
{
    public TextMeshProUGUI saveCounterText; // Reference to the UI Text object for saves
    public TextMeshProUGUI loadCounterText; // Reference to the UI Text object for loads
    
    private int saveCounter = 0; // Counter for save button clicks
    private int loadCounter = 0; // Counter for load button clicks

    private void Start()
    {
        ResetCounters();
    }

    public void IncrementSaveCounter()
    {
        saveCounter++;
        UpdateSaveCounterUI();
    }

    public void IncrementLoadCounter()
    {
        loadCounter++;
        UpdateLoadCounterUI();
    }

    public void ResetCounters()
    {
        saveCounter = 0;
        loadCounter = 0;
        UpdateSaveCounterUI();
        UpdateLoadCounterUI();
    }

    private void UpdateSaveCounterUI()
    {
        saveCounterText.text = "Saves: " + saveCounter.ToString();
    }

    private void UpdateLoadCounterUI()
    {
        loadCounterText.text = "Loads: " + loadCounter.ToString();
    }
}
