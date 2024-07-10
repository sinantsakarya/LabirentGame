using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator doorAnimator; // Kapýnýn Animator bileþeni
    public AnimationClip openAnimation; // Kapýnýn açýlma animasyonu

    private string openAnimationName; // Animasyonun adý

    void Start()
    {
        // Animasyonun adýný al
        openAnimationName = openAnimation.name;
    }

    void Update()
    {
        // Kapýyý açmak için bir kontrol
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Animasyonu oynat
            PlayOpenAnimation();
        }
    }

    void PlayOpenAnimation()
    {
        // Animator'da animasyonu oynat
        if (doorAnimator != null && openAnimation != null)
        {
            doorAnimator.Play(openAnimationName);
        }
        else
        {
            Debug.LogWarning("Animator veya animasyon referansý eksik.");
        }
    }
}
