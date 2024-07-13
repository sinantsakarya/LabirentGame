using UnityEngine;
using UnityEngine.UI;

public class BookController : MonoBehaviour
{
    public GameObject sayfa1;
    public GameObject sayfa2;
    public GameObject sayfa3;
    public GameObject sayfa4;

    static private bool sayfa1acik = true;
    static private bool sayfa2acik = false;
    static private bool sayfa3acik = false;
    static private bool sayfa4acik = false;

    void Start()
    {
        sayfa1.SetActive(true);
        sayfa2.SetActive(false);
        sayfa3.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (sayfa1acik)
            {
                sayfa1.SetActive(false);
                sayfa2.SetActive(true);
                sayfa1acik = false;
                sayfa2acik = true;
            }
            else if (sayfa2acik)
            {
                sayfa2.SetActive(false);
                sayfa3.SetActive(true);
                sayfa2acik = false;
                sayfa3acik = true;
                sayfa1acik = false;

            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
           if (sayfa3acik)
           {
                sayfa3.SetActive(false);
                sayfa2.SetActive(true);
                sayfa3acik = false;
                sayfa2acik = true;
                sayfa1acik = false;


            }
           else if (sayfa2acik)
           {
                sayfa2.SetActive(false);
                sayfa1.SetActive(true);
                sayfa2acik = false;
                sayfa1acik = true;

            }
        }
    }

    
}
