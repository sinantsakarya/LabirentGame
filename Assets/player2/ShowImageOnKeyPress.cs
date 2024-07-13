using UnityEngine;
using UnityEngine.UI;

public class ShowImageOnKeyPress : MonoBehaviour
{
    public GameObject imageToShow; // G�r�nt�lenecek Image GameObject'i
    public FirstPersonController firstPersonController;
    public Camera cam;
    private float distance;
    private Rigidbody selectedObject;

    void Start()
    {
        // firstPersonController'�n atan�p atanmad���n� kontrol edin
        if (firstPersonController == null)
        {
            return;
        }

        // Image'i ba�lang��ta devre d��� b�rak
        if (imageToShow != null)
        {
            imageToShow.SetActive(false);
        }
    }

    void Update()
    {
        RaycastHit hit;

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        // 'F' tu�una bas�ld���nda
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Physics.Raycast(ray, out hit, 2f))
            {
                if (hit.collider.gameObject.tag == "fbook")
                {
                    firstPersonController.cameraCanMove = false;
                    ToggleImage();
                }
            }
            if(firstPersonController.cameraCanMove != false)
            {
                firstPersonController.enabled = true;
            }
        }
    }

    void ToggleImage()
    {
        if (imageToShow != null)
        {
            bool isActive = !imageToShow.activeSelf;
            imageToShow.SetActive(isActive);

            // Kamera hareketini aktiflik durumuna g�re ayarla
            if (firstPersonController != null)
            {
                firstPersonController.cameraCanMove = !isActive;
                firstPersonController.enabled = false;
            }
        }
    }
}