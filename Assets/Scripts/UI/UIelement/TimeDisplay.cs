using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class handles displaying the time left
/// </summary>
public class TimeDisplay : UIelement
{
    [Header("References")]
    [Tooltip("The text to use when displaying the time")]
    public Text displayText = null;

    /// <summary>
    /// Description:
    /// Displays the time onto the display text
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    public void DisplayTime()
    {
        if (displayText != null)
        {
            displayText.text = "Time Left: " + Mathf.Max(GameManager.currentTime,0).ToString("0.00")+"s";
        }
    }

    /// <summary>
    /// Description:
    /// Updates this UI based on this class
    /// Input:
    /// none
    /// Return:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayTime();
    }
}
