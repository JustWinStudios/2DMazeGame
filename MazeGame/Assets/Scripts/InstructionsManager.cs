using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsManager : MonoBehaviour
{
    public GameObject instructionsPanel; // Assign in Inspector
    public GameObject buttonsObject; // Assign to Buttons Family

    public void ToggleInstructions()
    {
        bool isInstructionsActive = !instructionsPanel.activeSelf;
        instructionsPanel.SetActive(!instructionsPanel.activeSelf);

        //Toggles visibility of the main menu buttons
        if (buttonsObject != null)
        {
            buttonsObject.SetActive(!isInstructionsActive);
        }
    }

    public void HideInstructions()
    {
        instructionsPanel.SetActive(false); // Closes Instructions panel
        buttonsObject.SetActive(true); // Shows main menu buttons
    }
}