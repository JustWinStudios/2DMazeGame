using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsManager : MonoBehaviour
{
    public GameObject instructionsPanel; // Assign in Inspector

    public void ToggleInstructions()
    {
        instructionsPanel.SetActive(!instructionsPanel.activeSelf);
    }
}
