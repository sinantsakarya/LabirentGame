using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public Camera cam;
    public GameObject[] cubes = new GameObject[18];
    public GameObject[] crosses = new GameObject[18];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5.0f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("Tikladum");
                for (int i = 0; i < 18; i++)
                {
                    if (hit.collider.gameObject.tag == cubes[i].gameObject.tag)
                    {
                        if (!crosses[i].activeSelf)
                            crosses[i].SetActive(true);
                        else
                            crosses[i].SetActive(false);
                    }
                }

            }
        }
    }
}
