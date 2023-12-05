using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class AssetBundleLoader : MonoBehaviour
{
    public string prefabsURL;
    public string prefabName = "Test";
    private void Start()
    {
        StartCoroutine(LoadFromURL());
    }
    IEnumerator LoadFromURL()
    {
        UnityWebRequest request = UnityWebRequestAssetBundle.GetAssetBundle(prefabsURL);
        yield return request.SendWebRequest();
        if(request.result != UnityWebRequest.Result.Success)
        {
            yield break;
        }
        AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(request);
        GameObject prefab = bundle.LoadAsset<GameObject>(prefabName);
        Instantiate(prefab);
        bundle.Unload(false);
        yield return null;
    }
}
