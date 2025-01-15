using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour
{
    public Button blueButton;
    public Button yellowButton;
    public Button redButton;

    private void Start()
    {
        // Load the saved bird color on start and apply it
        BirdColor savedColor = (BirdColor)PlayerPrefs.GetInt("SelectedBirdColor", (int)BirdColor.Blue);
        ApplyBirdSprite(savedColor);

        // Set up button listeners
        blueButton.onClick.AddListener(() => OnColorSelected(BirdColor.Blue));
        yellowButton.onClick.AddListener(() => OnColorSelected(BirdColor.Yellow));
        redButton.onClick.AddListener(() => OnColorSelected(BirdColor.Red));
    }

    private void OnColorSelected(BirdColor color)
    {
        // Save the selected bird color to PlayerPrefs
        PlayerPrefs.SetInt("SelectedBirdColor", (int)color);
        PlayerPrefs.Save();

        // Apply the selected color's sprite
        Debug.Log($"Selected color: {color}");
        ApplyBirdSprite(color);
    }

    private void ApplyBirdSprite(BirdColor color)
    {
        // Find the Bird object and apply the correct sprite
        Debug.Log($"Apply color: {color}");
        Bird bird = FindObjectOfType<Bird>();
        if (bird != null)
        {
            bird.SetBirdSprite(color);
        }
    }

}
