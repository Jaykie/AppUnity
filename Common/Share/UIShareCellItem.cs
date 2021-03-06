﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIShareCellItem : UICellItemBase
{
    public Image imageItem;
    public Text textItem;

    string[] strImageBg = { AppRes.IMAGE_CELL_BG_BLUE, AppRes.IMAGE_CELL_BG_ORINGE, AppRes.IMAGE_CELL_BG_YELLOW };

    // Use this for initialization
    void Start()
    {

    }

    public override void UpdateItem(List<object> list)
    {
        ItemInfo info = list[index] as ItemInfo;
        textItem.text = info.title;
        textItem.color = AppRes.colorTitle;
        Vector4 border = AppRes.borderCellSettingBg;
        TextureUtil.UpdateImageTexture(imageItem, info.pic, true);

        RectTransform rctran = imageItem.GetComponent<RectTransform>();
        float w = imageItem.sprite.texture.width;//rectTransform.rect.width;
        float h = imageItem.sprite.texture.height;//rectTransform.rect.height;

        RectTransform rctranText = textItem.GetComponent<RectTransform>();
        RectTransform rctranContent = objContent.GetComponent<RectTransform>();
        float oft_y = rctranText.rect.height;
        float scalex = width / w;
        float scaley = (height - oft_y) / h;
        float scale = Mathf.Min(scalex, scaley);
        Debug.Log(" rctranContent.RECT="+rctranContent.rect);
        imageItem.transform.localScale = new Vector3(scale, scale, 1.0f);
        float x = 0;
        float y = oft_y / 2;

        rctran.anchoredPosition = new Vector2(x, y);

    }
    public override bool IsLock()
    {
        return false;
    }

}
