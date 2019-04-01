using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//布局
public class LayOutPhotoViewController : NaviViewController
{

    UILayOutPhoto uiPrefab;
    UILayOutPhoto ui; 
    public int index;
    static private LayOutPhotoViewController _main = null;
    public static LayOutPhotoViewController main
    {
        get
        {
            if (_main == null)
            {
                _main = new LayOutPhotoViewController();
                _main.Init();
            }
            return _main;
        }
    }


    void Init()
    {

        string strPrefab = "App/Prefab/LayOutPhoto/UILayOutPhoto";
        GameObject obj = PrefabCache.main.Load(strPrefab);
        if (obj != null)
        {
            uiPrefab = obj.GetComponent<UILayOutPhoto>();
        }

    }

    public override void ViewDidLoad()
    {
        base.ViewDidLoad();
        CreateUI();
    }
    public override void LayOutView()
    {
        base.LayOutView();
        Debug.Log("HomeViewController LayOutView ");
        if (ui != null)
        {
            ui.LayOut();
        }
    }
    public void CreateUI()
    {
        ui = (UILayOutPhoto)GameObject.Instantiate(uiPrefab);
        ui.SetController(this); 
        UIViewController.ClonePrefabRectTransform(uiPrefab.gameObject, ui.gameObject);
    } 
}

