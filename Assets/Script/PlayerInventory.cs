using UnityEngine;

public class PlayerInventory : MonoBehaviour // Inventario del jugador
{
    private static PlayerInventory instance;
    [SerializeField] private bool hasKey1 = false;
    [SerializeField] private bool hasKey2 = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Destruir objeto
        }
    }

    public static void TakeKey1()
    {
        instance.hasKey1 = true;
    }

    public static void TakeKey2()
    {
        instance.hasKey2 = true;
    }

    public static bool HasKey1()
    {
        return instance.hasKey1;
    }

    public static bool HasKey2()
    {
        return instance.hasKey2;
    }

    public static void ResetInventory()
    {
        instance.hasKey1 = false;
        instance.hasKey2 = false;
    }
    // Tus putos muertos
    // ME CAGO EN TUS MUERTOS, HIJO DE PUTA
}
