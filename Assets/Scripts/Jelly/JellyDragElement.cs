using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JellyDragElement : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Image mainImage;
    /// <summary>
    /// ������ ����������� ���� ��������
    /// </summary>
    public Sprite Sprite
    {
        get { return mainImage.sprite; }
        set
        {
            if (value != null)
            {
                mainImage.sprite = value;
            }
        }
    }

    public void SpriteEditor(Sprite sprite)
    {
        if (sprite != null)
            mainImage.sprite = sprite;
    }
    private GameObject objectToSpawn;
    /// <summary>
    /// GameObject ����������� ���� ���������
    /// </summary>
    public GameObject ObjectToSpawn
    {
        get { return objectToSpawn; }
        set
        {
            if (value != null)
            {
                objectToSpawn = value;
            }
        }
    }

    private Transform defaultParentTransform;
    /// <summary>
    /// ��������� �������, � �������� ����������� ������
    /// </summary>
    public Transform DefaultParentTransform
    {
        get { return defaultParentTransform; }
        set
        {
            if (value != null)
            {
                defaultParentTransform = value;
            }
        }
    }

    private Transform dragParentTransform;
    /// <summary>
    /// ��������� �������, � �������� ������������� ������ �� ����� �����
    /// </summary>
    public Transform DragParentTransform
    {
        get { return dragParentTransform; }
        set
        {
            if (value != null)
                dragParentTransform = value;
        }
    }

    private int siblingIndex;
    /// <summary>
    /// ����� ������� ������ ������������� �������
    /// </summary>
    public int SiblingIndex
    {
        get { return siblingIndex; }
        set
        {
            if (value > 0)
                siblingIndex = value;
        }
    }

    private string tagToEnable;
    /// <summary>
    /// ��� ��� ��������� �������
    /// </summary>
    public string TagToEnable
    {
        get { return tagToEnable; }
        set { tagToEnable = value; }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(DragParentTransform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //�o����� ��� � ���
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        //������� ���
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "Bowl")
            {
                var obj = hit.collider.transform.Find(tagToEnable).gameObject;
                obj.SetActive(true);
            }
        }

        //�o�������� ������� � ������� �������
        transform.SetParent(DefaultParentTransform);
        transform.SetSiblingIndex(SiblingIndex);
    }
}
