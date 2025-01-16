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
        MenuBirdColor savedColor = (MenuBirdColor)PlayerPrefs.GetInt("SelectedBirdColor", (int)MenuBirdColor.Blue);
        ApplyBirdSprite(savedColor);

        // Set up button listeners
        blueButton.onClick.AddListener(() => OnColorSelected(MenuBirdColor.Blue));
        yellowButton.onClick.AddListener(() => OnColorSelected(MenuBirdColor.Yellow));
        redButton.onClick.AddListener(() => OnColorSelected(MenuBirdColor.Red));
    }

    private void OnColorSelected(MenuBirdColor color)
    {
        // Save the selected bird color to PlayerPrefs
        PlayerPrefs.SetInt("SelectedBirdColor", (int)color);
        PlayerPrefs.Save();

        // Apply the selected color's sprite
        Debug.Log($"Selected color: {color}");
        ApplyBirdSprite(color);
    }

    private void ApplyBirdSprite(MenuBirdColor color)
    {
        // Find the Bird object and apply the correct sprite
        Debug.Log($"Apply color: {color}");
        ChangeBirdMenu bird = FindObjectOfType<ChangeBirdMenu>();
        if (bird != null)
        {
            bird.SetBirdSprite(color);
        }
    }

}
