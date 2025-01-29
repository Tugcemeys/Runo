using UnityEngine;

public class GameManager : MonoBehaviour
{
public int point;
    public GameObject[] RayObj;

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RaycastHit hit;
            if (Physics.Raycast(RayObj[0].transform.position,transform.forward,out hit,1))
            {
                if (hit.collider.gameObject.CompareTag("Nota"))
                {
                    GameObject clickednote=hit.collider.gameObject;
                    clickednote.SetActive(false);
                    if (Vector3.Distance(clickednote.transform.position, RayObj[0].transform.position) <= 0.1f+0.1f*clickednote.GetComponent<NotaMovement>().speed)
                    {
                        point++;
                    }
                    else { }
                }
            }
            else if (Physics.Raycast(RayObj[0].transform.position, -transform.forward, out hit, 1))
            {
                GameObject clickednote = hit.collider.gameObject;
                clickednote.SetActive(false);
                if (Vector3.Distance(clickednote.transform.position, RayObj[0].transform.position) <= 0.1f + 0.1f * clickednote.GetComponent<NotaMovement>().speed)
                {
                    point++;
                }
                else { }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RaycastHit hit;
            if (Physics.Raycast(RayObj[1].transform.position, transform.forward, out hit, 1))
            {
                if (hit.collider.gameObject.CompareTag("Nota"))
                {
                    GameObject clickednote = hit.collider.gameObject;
                    clickednote.SetActive(false);
                    if (Vector3.Distance(clickednote.transform.position, RayObj[1].transform.position) <= 0.1f + 0.1f * clickednote.GetComponent<NotaMovement>().speed)
                    {
                        point++;
                    }
                    else { }
                }
            }
            else if (Physics.Raycast(RayObj[1].transform.position, -transform.forward, out hit, 1))
            {
                GameObject clickednote = hit.collider.gameObject;
                clickednote.SetActive(false);
                if (Vector3.Distance(clickednote.transform.position, RayObj[1].transform.position) <= 0.1f + 0.1f * clickednote.GetComponent<NotaMovement>().speed)
                {
                    point++;
                }
                else { }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RaycastHit hit;
            if (Physics.Raycast(RayObj[2].transform.position, transform.forward, out hit, 1))
            {
                if (hit.collider.gameObject.CompareTag("Nota"))
                {
                    GameObject clickednote = hit.collider.gameObject;
                    clickednote.SetActive(false);
                    if (Vector3.Distance(clickednote.transform.position, RayObj[2].transform.position) <= 0.1f + 0.1f * clickednote.GetComponent<NotaMovement>().speed)
                    {
                        point++;
                    }
                    else { }
                }
            }
            else if (Physics.Raycast(RayObj[2].transform.position, -transform.forward, out hit, 1))
            {
                GameObject clickednote = hit.collider.gameObject;
                clickednote.SetActive(false);
                if (Vector3.Distance(clickednote.transform.position, RayObj[2].transform.position) <= 0.1f + 0.1f * clickednote.GetComponent<NotaMovement>().speed)
                {
                    point++;
                }
                else { }
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            RaycastHit hit;
            if (Physics.Raycast(RayObj[3].transform.position, transform.forward, out hit, 1))
            {
                if (hit.collider.gameObject.CompareTag("Nota"))
                {
                    GameObject clickednote = hit.collider.gameObject;
                    clickednote.SetActive(false);
                    if (Vector3.Distance(clickednote.transform.position, RayObj[3].transform.position) <= 0.1f + 0.1f * clickednote.GetComponent<NotaMovement>().speed)
                    {
                        point++;
                    }
                    else { }
                }
            }
            else if (Physics.Raycast(RayObj[3].transform.position, -transform.forward, out hit, 1))
            {
                GameObject clickednote = hit.collider.gameObject;
                clickednote.SetActive(false);
                if (Vector3.Distance(clickednote.transform.position, RayObj[3].transform.position) <= 0.1f + 0.1f * clickednote.GetComponent<NotaMovement>().speed)
                {
                    point++;
                }
                else { }
            }
        }
    }
}