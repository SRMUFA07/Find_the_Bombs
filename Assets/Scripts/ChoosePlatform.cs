using UnityEngine;

public class ChoosePlatform : MonoBehaviour
{
    public static bool pcDevise;

    public void PcButtonDown() 
    {
        pcDevise = true;
    }

    public void PhoneButtonDown() 
    {
        pcDevise = false;
    }
}
