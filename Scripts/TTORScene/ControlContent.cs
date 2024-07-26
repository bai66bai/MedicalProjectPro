using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlContent : MonoBehaviour
{
    public List<GameObject> BtnCtrs;
    public List<Image> BgImages;


    public void BtnClick(GameObject go) =>
        BtnCtrs.ForEach(c =>
        {
            int index = BtnCtrs.IndexOf(c);
            BgImages[index].enabled = c.name == go.name;
        });

}
