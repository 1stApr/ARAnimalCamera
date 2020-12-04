using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.InteropServices;

public class ScreenShot : MonoBehaviour
{

    private bool isProcessing = false;
    public GameObject canvas1;
    public static string imageCurrentPath = "A";
    void Start()
    {
        imageCurrentPath = "A";
        canvas1.transform.localScale = new Vector3(0, 0, 0);
    }
    public void Shot()
    {

        if (!isProcessing)
            StartCoroutine(Shot2());
        //Debug.Log("No sharing set up for this platform.");
    }

    public IEnumerator Shot2()
    {
        isProcessing = true;
        yield return new WaitForEndOfFrame();

        string myFileName = "Screenshot" + System.DateTime.Now.Hour + System.DateTime.Now.Minute + System.DateTime.Now.Second + ".png";
        string myDefaultLocation = Application.persistentDataPath + "/" + myFileName;
        string myFolderLocation = "/storage/emulated/0/DCIM/Vuon Thu Ao/";
        string myScreenshotLocation = myFolderLocation + myFileName;
        imageCurrentPath = myScreenshotLocation;

        if (!System.IO.Directory.Exists(myFolderLocation))
        {
            System.IO.Directory.CreateDirectory(myFolderLocation);
        }
        
        canvas1.transform.localScale = new Vector3(1f, 1f, 1f); ;

        yield return new WaitForEndOfFrame();
        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        // Save the screenshot to Gallery
        //Debug.Log("Permission result: " + NativeGallery.SaveImageToGallery(ss, "Vuon Thu Ao", myFileName));
        NativeGallery.SaveImageToGallery(ss, "Vuon Thu Ao", myFileName);
        // To avoid memory leaks
        Destroy(ss);
        canvas1.transform.localScale = new Vector3(0, 0, 0);
        isProcessing = false;

        AndroidContentOpenerWrapper.OpenContent(myScreenshotLocation);

    }

}

