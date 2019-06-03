using UnityEngine;
using UnityEditor;

public class AddNameSpace : UnityEditor.AssetModificationProcessor
{

    public static void OnWillCreateAsset(string path)
    {
        path = path.Replace(".meta", "");
        int index = path.LastIndexOf(".");
        if (index < 0) return;
        string file = path.Substring(index);
        if (file != ".cs" && file != ".js" && file != ".boo") return;
        index = Application.dataPath.LastIndexOf("Assets");
        path = Application.dataPath.Substring(0, index) + path;
        file = System.IO.File.ReadAllText(path);

        string lastPart = path.Substring(path.IndexOf("Assets"));
        string currentNamespace = lastPart.Substring(0, lastPart.LastIndexOf('/'));
        currentNamespace = currentNamespace.Replace('/', '.');
        currentNamespace = currentNamespace.Replace("Assets", "Cyberkanoid");
        file = file.Replace("#NAMESPACE#", currentNamespace);

        System.IO.File.WriteAllText(path, file);
        AssetDatabase.Refresh();
    }
}