using UnityEngine;

public class Test : MonoBehaviour
{
    public Animator doorAnimator; // Kapýnýn Animator bileþeni
    public AnimationClip openAnimation; // Kapýnýn açýlma animasyonu
    public Animator buttonAnimator;
    public AnimationClip openButton;
    private string openAnimationName; // Açýlma animasyonunun adý
    private string openButtonName; // Buton açýlma animasyonunun adý

    void Start()
    {
        // Animasyon adlarýný al
        if (openAnimation != null)
        {
            openAnimationName = openAnimation.name;
        }
        else
        {
            Debug.LogWarning("Açýlma animasyon referansý eksik.");
        }

        if (openButton != null)
        {
            openButtonName = openButton.name;
        }
        else
        {
            Debug.LogWarning("Buton açýlma animasyon referansý eksik.");
        }
    }

    void Update()
    {
        // Mouse sol týklama ile objeyi kontrol et
        if (Input.GetMouseButtonDown(0)) // Sol mouse tuþuna basýldýðýnda
        {
            // Týklanan objeyi al
            GameObject clickedObject = GetClickedObject();
            if (clickedObject != null && clickedObject.CompareTag("Interactable"))
            {
                // Açýlma animasyonunu oynat
                PlayOpenAnimation();
            }
            else if (clickedObject != null && clickedObject.CompareTag("Door"))
            {
                // Kapý açýlma animasyonunu oynat
                PlayDoorAnimation();
            }
        }
    }

    void PlayOpenAnimation()
    {
        // Animator'da kapý açýlma animasyonunu oynat
        if (doorAnimator != null && openAnimation != null)
        {
            doorAnimator.Play(openAnimationName);
        }
        else
        {
            Debug.LogWarning("Kapý Animator veya açýlma animasyon referansý eksik.");
        }

        // Animator'da buton açýlma animasyonunu oynat
        if (buttonAnimator != null && openButton != null)
        {
            buttonAnimator.Play(openButtonName);
        }
        else
        {
            Debug.LogWarning("Buton Animator veya açýlma animasyon referansý eksik.");
        }
    }

    void PlayDoorAnimation()
    {
        // Kapý Animator'da açýlma animasyonunu oynat
        if (doorAnimator != null && openAnimation != null)
        {
            doorAnimator.Play(openAnimationName);
        }
        else
        {
            Debug.LogWarning("Kapý Animator veya açýlma animasyon referansý eksik.");
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
