using UnityEngine;

public class BirdSkinManager : MonoBehaviour
{
    public Animator birdAnimator;  // Reference to the Animator component
    public SpriteRenderer birdSpriteRenderer;  // Reference to the SpriteRenderer for color/skin change

    public Sprite[] birdSkins;  // Array of bird sprites (for different skins)
    public RuntimeAnimatorController[] birdAnimations;  // Array of animator controllers (one per skin)

    private int selectedSkinIndex;

    void Start()
    {
        // Retrieve the selected skin index from PlayerPrefs (or other persistence method)
        selectedSkinIndex = PlayerPrefs.GetInt("SelectedBirdColor", 0);  // Default to 0 if not set

        // Set the bird's skin sprite
        if (selectedSkinIndex >= 0 && selectedSkinIndex < birdSkins.Length)
        {
            Debug.Log("Skin selected successfully");
            birdSpriteRenderer.sprite = birdSkins[selectedSkinIndex];
        }

        // Set the animator controller based on the selected skin
        if (selectedSkinIndex >= 0 && selectedSkinIndex < birdAnimations.Length)
        {
            Debug.Log("Animation selected successfully");
            birdAnimator.runtimeAnimatorController = birdAnimations[selectedSkinIndex];
        }
    }
}