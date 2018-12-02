using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerMaskSwapper : MonoBehaviour
{
    public Camera player1Camera;

    public LayerMask player1LayerMask;
    public LayerMask player2LayerMask;
    [SerializeField]
    private LayerMask allLayers;

    // Start is called before the first frame update
    void Start()
    {
        allLayers = LayerMask.NameToLayer("Everything");
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Alpha1))
        {
            ResetLayerMask(player1Camera);
        }

        if (Input.GetKey(KeyCode.Plus))
        {
            Debug.Log("plus");
            MakeLayerVisible(player1Camera, player1LayerMask);
        }

        if (Input.GetKey(KeyCode.Minus))
        {
            Debug.Log("minus");
            MakeLayerInvisible(player1Camera, player1LayerMask);
        }
    }

    private void MakeLayerVisible(Camera cam, LayerMask layerMask)
    {
        // newMask = oldMask | (1 << 9);
        player1Camera.cullingMask = allLayers | 1 << player1LayerMask;

    }

    private void ResetLayerMask(Camera cam)
    {
        cam.cullingMask = allLayers;
    }

    private void MakeLayerInvisible(Camera cam, LayerMask layerMask)
    {
        // var newMask = oldMask & ~(1 << 9
        player1Camera.cullingMask = allLayers & ~(1 << player1LayerMask);
    }
}
