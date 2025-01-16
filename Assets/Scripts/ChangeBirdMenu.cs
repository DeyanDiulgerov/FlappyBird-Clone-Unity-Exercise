using UnityEngine;
using UnityEngine.UI;

public class ChangeBirdMenu : MonoBehaviour
{
    public Image spriteRenderer;  // Reference to the SpriteRenderer component
    public Sprite blueBirdSprite;          // Blue bird sprite
    public Sprite yellowBirdSprite;        // Yellow bird sprite
    public Sprite redBirdSprite;           // Red bird sprite

    private void Start()
    {
        // Load the saved bird color from PlayerPrefs (default to Blue if no selection)
        MenuBirdColor savedColor = (MenuBirdColor)PlayerPrefs.GetInt("SelectedBirdColor", (int)MenuBirdColor.Blue);
        SetBirdSprite(savedColor);
    }

    // Set the bird sprite based on the selected color
    public void SetBirdSprite(MenuBirdColor color)
    {
        switch (color)
        {
            case MenuBirdColor.Blue:
                spriteRenderer.sprite = blueBirdSprite;
                break;
            case MenuBirdColor.Yellow:
                spriteRenderer.sprite = yellowBirdSprite;
                break;
            case MenuBirdColor.Red:
                spriteRenderer.sprite = redBirdSprite;
                break;
        }
    }
}

public enum MenuBirdColor
{
    Blue,
    Yellow,
    Red
}
