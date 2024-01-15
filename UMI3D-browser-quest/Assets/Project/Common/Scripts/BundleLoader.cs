using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BundleLoader : MonoBehaviour
{

    // Start is called before the first frame update
    void Awake()
    {       

        string path = Application.persistentDataPath;
        DirectoryInfo dataDir = new DirectoryInfo(path);
        try
        {
            FileInfo[] fileinfo = dataDir.GetFiles();
            for (int i = 0; i < fileinfo.Length; i++)
            {
                string name = fileinfo[i].Name;
                if (name.EndsWith(".bundle"))
                {
                    Debug.Log("loading bundle : " + name + " ...");
                    AssetBundle bundle = AssetBundle.LoadFromFile(Application.persistentDataPath + "\\" + name);
                    if (bundle != null)
                    {
                        foreach (string s in bundle.GetAllAssetNames())
                            Debug.Log("...  " + s + " loaded");
                        Debug.Log("... sucess");
                    }
                    else
                    {
                        Debug.Log("!!! failed !");
                    }
                }
                
            }
        }
        catch (System.Exception e)
        {
            Debug.Log(e);
        }
    }

   

}
