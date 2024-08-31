using UnityEngine;

public class DisconnectWhenRemove : MonoBehaviour
{
    public ScreenCastBtn screenCastBtn;

    // Update is called once per frame
    void Update()
    {
        if(screenCastBtn.IsOnScreen && Input.touchCount == 0)
        {
            screenCastBtn.ChangeScreenCast(string.Empty);
        }
    }
}
