using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PLINKO;
using UnityEngine.EventSystems;


/// <summary>
/// @obj    DiscSpawnerArea
/// @desc   click/tap on canvas to intantiate discs
/// </summary>
public class DiscSpawner : MonoBehaviour, IPointerDownHandler
{
    // private Vector3 m_newPos;
    private float m_defY = 10.60f;
    private float m_defZ = 0.337f;
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
        // Debug.Log(downEventData);
        Vector3 m_newPos = Camera.main.ScreenToWorldPoint(new Vector3(
            downEventData.position.x,
            downEventData.position.y,
            10
            ));
        // print(m_newPos);
        Vector3 discPos = new Vector3(
            m_newPos.x,
            m_defY,
            m_defZ
        );

        GameObject newDisc = Instantiate(
            m_discPrefab,
            discPos,
            Quaternion.Euler(90, 0, 0),
            m_discHolder
        );
        GameManager.Instance.m_canAddDisc = false;
    }

}
