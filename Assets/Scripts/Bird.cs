using UnityEngine;
using UnityEngine.UI;
using static CharacterSelect;

public class Bird : MonoBehaviour
{
    public Image spriteRenderer;  // Reference to the SpriteRenderer component
    public Sprite blueBirdSprite;          // Blue bird sprite
    public Sprite yellowBirdSprite;        // Yellow bird sprite
    public Sprite redBirdSprite;           // Red bird sprite

    private void Start()
    {
        // Load the saved bird color from PlayerPrefs (default to Blue if no selection)
        BirdColor savedColor = (BirdColor)PlayerPrefs.GetInt("SelectedBirdColor", (int)BirdColor.Blue);
        SetBirdSprite(savedColor);
    }

    // Set the bird sprite based on the selected color
    public void SetBirdSprite(BirdColor color)
    {
        switch (color)
        {
            case BirdColor.Blue:
                spriteRenderer.sprite = blueBirdSprite;
                break;
            case BirdColor.Yellow:
                spriteRenderer.sprite = yellowBirdSprite;
                break;
            case BirdColor.Red:
                spriteRenderer.sprite = redBirdSprite;
                break;
        }
    }
}

// Enum to represent the bird color (linked to sprite choice)
public enum BirdColor
{
    Blue,
    Yellow,
    Red
}
