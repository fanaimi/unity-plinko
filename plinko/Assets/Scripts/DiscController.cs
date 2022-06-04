using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PLINKO;
using UnityEngine.EventSystems;


/// <summary>
/// @obj    PlinkoCanvas
/// @desc   click/tap on canvas to intantiate discs
/// </summary>
public class DiscController : MonoBehaviour, IPointerDownHandler
{
    private Vector3 m_newPos;
    [SerializeField] private GameObject m_discPrefab;
    [SerializeField] private Transform m_discHolder;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData downEventData)
    {
        if (!GameManager.Instance.m_canAddDisc) return;
        Debug.Log(downEventData);
        m_newPos = downEventData.position;
        Vector3 discPos = new Vector3(0,0,0);

        GameObject newDisc = Instantiate(
            m_discPrefab, 
            discPos, 
            Quaternion.identity, 
            m_discHolder
        );
    }

}
