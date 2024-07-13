using UnityEngine;

public class Test : MonoBehaviour
{
    public Animator doorAnimator; // Kap�n�n Animator bile�eni
    public AnimationClip openAnimation; // Kap�n�n a��lma animasyonu
    public Animator buttonAnimator;
    public AnimationClip openButton;
    private string openAnimationName; // A��lma animasyonunun ad�
    private string openButtonName; // Buton a��lma animasyonunun ad�

    void Start()
    {
        // Animasyon adlar�n� al
        if (openAnimation != null)
        {
            openAnimationName = openAnimation.name;
        }
        else
        {
            Debug.LogWarning("A��lma animasyon referans� eksik.");
        }

        if (openButton != null)
        {
            openButtonName = openButton.name;
        }
        else
        {
            Debug.LogWarning("Buton a��lma animasyon referans� eksik.");
        }
    }

    void Update()
    {
        // Mouse sol t�klama ile objeyi kontrol et
        if (Input.GetMouseButtonDown(0)) // Sol mouse tu�una bas�ld���nda
        {
            // T�klanan objeyi al
            GameObject clickedObject = GetClickedObject();
            if (clickedObject != null && clickedObject.CompareTag("Interactable"))
            {
                // A��lma animasyonunu oynat
                PlayOpenAnimation();
            }
            else if (clickedObject != null && clickedObject.CompareTag("Door"))
            {
                // Kap� a��lma animasyonunu oynat
                PlayDoorAnimation();
            }
        }
    }

    void PlayOpenAnimation()
    {
        // Animator'da kap� a��lma animasyonunu oynat
        if (doorAnimator != null && openAnimation != null)
        {
            doorAnimator.Play(openAnimationName);
        }
        else
        {
            Debug.LogWarning("Kap� Animator veya a��lma animasyon referans� eksik.");
        }

        // Animator'da buton a��lma animasyonunu oynat
        if (buttonAnimator != null && openButton != null)
        {
            buttonAnimator.Play(openButtonName);
        }
        else
        {
            Debug.LogWarning("Buton Animator veya a��lma animasyon referans� eksik.");
        }
    }

    void PlayDoorAnimation()
    {
        // Kap� Animator'da a��lma animasyonunu oynat
        if (doorAnimator != null && openAnimation != null)
        {
            doorAnimator.Play(openAnimationName);
        }
        else
        {
            Debug.LogWarning("Kap� Animator veya a��lma animasyon referans� eksik.");
        }
    }

    GameObject GetClickedObject()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            return hit.collider.gameObject;
        }

        return null;
    }
}
