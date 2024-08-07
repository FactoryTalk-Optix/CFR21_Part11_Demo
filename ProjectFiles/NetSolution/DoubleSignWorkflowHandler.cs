#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.UI;
using FTOptix.Retentivity;
using FTOptix.NativeUI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.EventLogger;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.AuditSigning;
using FTOptix.Alarm;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
using FTOptix.Modbus;
using FTOptix.DataLogger;
using FTOptix.Recipe;
using FTOptix.Report;
using FTOptix.WebUI;
using FTOptix.ODBCStore;
using FTOptix.OPCUAServer;
using FTOptix.EdgeAppPlatform;
#endregion

public class DoubleSignWorkflowHandler : BaseNetLogic
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined logic is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
