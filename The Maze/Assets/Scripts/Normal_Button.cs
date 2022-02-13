using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal_Button : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;
    public GameObject MazeUint,Bridge;
    public bool IsItBride = false;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
            MazeUint.SetActive(true);
            mat.color = new Color(0, 0.8f, 0);
            

            if(IsItBride)
            {
                Bridge.SetActive(false);
            }
       }
    }
}
