using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlContent : MonoBehaviour
{
    public List<GameObject> BtnCtrs;
    public List<Image> BgImages;
    public TCPClient client;

    private void OnEnable()
    {
        BgImages.ForEach(item =>
        {
            if(item.enabled == true)
            {
                client.SendMessage($"MbtnName:{BtnCtrs[BgImages.IndexOf(item)].name}-{TTORStore.ID}");
            }
        });
    }


    public void BtnClick(GameObject go) =>
        BtnCtrs.ForEach(c =>
        {
            int index = BtnCtrs.IndexOf(c);
            if(c.name == go.name)
            {
                client.SendMessage($"MbtnName:{go.name}-{TTORStore.ID}");
                BgImages[index].enabled = true;
            }
            else
            {
                BgImages[index].enabled = false;
            }
        });

}
