using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour

{

    public Camera[] cameras;


    private int cameraIndex;

    // Start is called before the first frame update
    void Start()
    {

        cameraIndex = 0;

        for (int index = 1; index < cameras.Length; index++)


            cameras[index].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))


        {

            cameraIndex++;
            Debug.Log("Switch camera");
            if (cameraIndex < cameras.Length)
            {

                cameras[cameraIndex - 1].gameObject.SetActive(false);


                cameras[cameraIndex].gameObject.SetActive(true);

                Debug.Log("Camera " + cameras[cameraIndex].GetComponent<Camera>().name + ", activated");
            }



            else

            {


                cameras[cameraIndex - 1].gameObject.SetActive(false);


                cameraIndex = 0;


                cameras[cameraIndex].gameObject.SetActive(true);


                Debug.Log("Camera " + cameras[cameraIndex].GetComponent<Camera>().name + ", activated");


            }

        }
    }
}


    
