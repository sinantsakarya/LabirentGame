using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator doorAnimator; // Kap�n�n Animator bile�eni
    public AnimationClip openAnimation; // Kap�n�n a��lma animasyonu

    private string openAnimationName; // Animasyonun ad�

    void Start()
    {
        // Animasyonun ad�n� al
        openAnimationName = openAnimation.name;
    }

    void Update()
    {
        // Kap�y� a�mak i�in bir kontrol
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
            Debug.LogWarning("Animator veya animasyon referans� eksik.");
        }
    }
}
