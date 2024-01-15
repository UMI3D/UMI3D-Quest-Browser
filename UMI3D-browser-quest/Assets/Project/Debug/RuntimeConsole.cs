using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages a runtime console to debug.
/// </summary>
public class RuntimeConsole : MonoBehaviour
{
    public ScrollRect logScrollbar;
    public ScrollRect logErrorScrollbar;

    public GameObject logContainer;
    public GameObject logErrorContainer;

    public GameObject logPrefab;
    public GameObject logErrorPrefab;

    public Text stackTrace;

    Dictionary<string, GameObject> logs = new Dictionary<string, GameObject>();

    void OnEnable()
    {
        Application.logMessageReceived += HandleLog;

        for (int i = 0; i < 200; i++)
        {
            Debug.Log("POmme " + i);
        }
    }

    void OnDisable()
    {
        Application.logMessageReceived -= HandleLog;
    }

    /// <summary>
    /// Displays a log, logError or Exception.
    /// </summary>
    /// <param name="logString"></param>
    /// <param name="stackTrace"></param>
    /// <param name="type"></param>
    void HandleLog(string logString, string stackTrace, LogType type)
    {
        if (type == LogType.Log)
        {
            if (!logs.ContainsKey(logString))
            {
                var item = Instantiate(logErrorPrefab, logContainer.transform);
                item.SetActive(true);
                item.GetComponentInChildren<Text>().text = logString + stackTrace;
                item.transform.SetAsFirstSibling();
                logs.Add(logString, item);
            } else
            {
                logs[logString].transform.SetAsFirstSibling();
            }
        }
        else if (type == LogType.Exception || type == LogType.Error)
        {
            var item = Instantiate(logErrorPrefab, logErrorContainer.transform);
            item.SetActive(true);
            item.GetComponentInChildren<Text>().text = logString;
            item.GetComponent<Button>().onClick.AddListener(() =>
            {
                this.stackTrace.text = stackTrace.Length > 500 ? stackTrace.Substring(0, 500) : stackTrace;
            });
            item.transform.SetAsFirstSibling();
        }
    }

    [ContextMenu("Scroll up")]
    public void ScrollLog()
    {
        logScrollbar.verticalNormalizedPosition += 0.1f;
    }

    [ContextMenu("Scroll down")]
    public void ScrollLogDown()
    {
        logScrollbar.verticalNormalizedPosition -= 0.1f;
    }
}
