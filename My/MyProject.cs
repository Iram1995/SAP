
// Type: SAP2012.My.MyProject




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SAP2012.My
{
  [StandardModule]
  [HideModuleName]
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public About m_About;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public AddAddressForm m_AddAddressForm;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public AddNewAddress m_AddNewAddress;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public AreaCalc m_AreaCalc;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Batch_Lodgement m_Batch_Lodgement;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Batch_Report m_Batch_Report;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Batch_Results m_Batch_Results;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Block_Compliance m_Block_Compliance;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Block_Name m_Block_Name;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Boiler_Database m_Boiler_Database;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public CalculationType_ScotlandOnly m_CalculationType_ScotlandOnly;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public CHP_Search m_CHP_Search;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Clients m_Clients;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ConnectionCheck m_ConnectionCheck;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Controls m_Controls;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Copy_Dwelling m_Copy_Dwelling;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Copy_Element m_Copy_Element;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Copy_Multiple m_Copy_Multiple;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Copy_Opening m_Copy_Opening;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public DER_TER_Results m_DER_TER_Results;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Doors m_Doors;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ECOForm m_ECOForm;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public EPC_Viewer m_EPC_Viewer;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Error_Message m_Error_Message;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public FGHRS_Form m_FGHRS_Form;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public GenResults m_GenResults;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public HeatPump_SearchFrm m_HeatPump_SearchFrm;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public HQMHistory m_HQMHistory;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public HQMLodgements m_HQMLodgements;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Htb_Calculator2012 m_Htb_Calculator2012;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Import2005 m_Import2005;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Import2009Frm m_Import2009Frm;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Import2012Frm m_Import2012Frm;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Key_Results m_Key_Results;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Lodgement m_Lodgement;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Lodgement_History m_Lodgement_History;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Lodgement_Result m_Lodgement_Result;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Lodgements_Successful m_Lodgements_Successful;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Logo m_Logo;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Main m_Main;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Members_Details m_Members_Details;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Monthly_Form m_Monthly_Form;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MoveToo m_MoveToo;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Notes m_Notes;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Ordering m_Ordering;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Products m_Products;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Reports m_Reports;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public RoofWindows m_RoofWindows;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public SAPForm m_SAPForm;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Save m_Save;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Saved m_Saved;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Shelter m_Shelter;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public SingleHQM m_SingleHQM;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Solid_Search m_Solid_Search;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Splash m_Splash;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public StorageHeaterSelection m_StorageHeaterSelection;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public StorageSelectionVessel m_StorageSelectionVessel;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Trial m_Trial;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Updates m_Updates;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public UvalueChanges m_UvalueChanges;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public UValues m_UValues;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public SAP2012.Version m_Version;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public VersionHistroy m_VersionHistroy;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public WarmAirSearch m_WarmAirSearch;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public SAP2012.Windows m_Windows;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Work m_Work;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public WorkSheetView m_WorkSheetView;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public WWHRSForm m_WWHRSForm;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public XML m_XML;

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        TargetInvocationException invocationException;
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          invocationException = ex;
          if (invocationException.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", invocationException.InnerException.Message), invocationException.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType() => typeof (MyProject.MyForms);

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString() => base.ToString();

      public About About
      {
        [DebuggerHidden] get
        {
          this.m_About = MyProject.MyForms.Create__Instance__<About>(this.m_About);
          return this.m_About;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_About)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<About>(ref this.m_About);
        }
      }

      public AddAddressForm AddAddressForm
      {
        [DebuggerHidden] get
        {
          this.m_AddAddressForm = MyProject.MyForms.Create__Instance__<AddAddressForm>(this.m_AddAddressForm);
          return this.m_AddAddressForm;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_AddAddressForm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<AddAddressForm>(ref this.m_AddAddressForm);
        }
      }

      public AddNewAddress AddNewAddress
      {
        [DebuggerHidden] get
        {
          this.m_AddNewAddress = MyProject.MyForms.Create__Instance__<AddNewAddress>(this.m_AddNewAddress);
          return this.m_AddNewAddress;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_AddNewAddress)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<AddNewAddress>(ref this.m_AddNewAddress);
        }
      }

      public AreaCalc AreaCalc
      {
        [DebuggerHidden] get
        {
          this.m_AreaCalc = MyProject.MyForms.Create__Instance__<AreaCalc>(this.m_AreaCalc);
          return this.m_AreaCalc;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_AreaCalc)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<AreaCalc>(ref this.m_AreaCalc);
        }
      }

      public Batch_Lodgement Batch_Lodgement
      {
        [DebuggerHidden] get
        {
          this.m_Batch_Lodgement = MyProject.MyForms.Create__Instance__<Batch_Lodgement>(this.m_Batch_Lodgement);
          return this.m_Batch_Lodgement;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Batch_Lodgement)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Batch_Lodgement>(ref this.m_Batch_Lodgement);
        }
      }

      public Batch_Report Batch_Report
      {
        [DebuggerHidden] get
        {
          this.m_Batch_Report = MyProject.MyForms.Create__Instance__<Batch_Report>(this.m_Batch_Report);
          return this.m_Batch_Report;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Batch_Report)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Batch_Report>(ref this.m_Batch_Report);
        }
      }

      public Batch_Results Batch_Results
      {
        [DebuggerHidden] get
        {
          this.m_Batch_Results = MyProject.MyForms.Create__Instance__<Batch_Results>(this.m_Batch_Results);
          return this.m_Batch_Results;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Batch_Results)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Batch_Results>(ref this.m_Batch_Results);
        }
      }

      public Block_Compliance Block_Compliance
      {
        [DebuggerHidden] get
        {
          this.m_Block_Compliance = MyProject.MyForms.Create__Instance__<Block_Compliance>(this.m_Block_Compliance);
          return this.m_Block_Compliance;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Block_Compliance)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Block_Compliance>(ref this.m_Block_Compliance);
        }
      }

      public Block_Name Block_Name
      {
        [DebuggerHidden] get
        {
          this.m_Block_Name = MyProject.MyForms.Create__Instance__<Block_Name>(this.m_Block_Name);
          return this.m_Block_Name;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Block_Name)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Block_Name>(ref this.m_Block_Name);
        }
      }

      public Boiler_Database Boiler_Database
      {
        [DebuggerHidden] get
        {
          this.m_Boiler_Database = MyProject.MyForms.Create__Instance__<Boiler_Database>(this.m_Boiler_Database);
          return this.m_Boiler_Database;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Boiler_Database)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Boiler_Database>(ref this.m_Boiler_Database);
        }
      }

      public CalculationType_ScotlandOnly CalculationType_ScotlandOnly
      {
        [DebuggerHidden] get
        {
          this.m_CalculationType_ScotlandOnly = MyProject.MyForms.Create__Instance__<CalculationType_ScotlandOnly>(this.m_CalculationType_ScotlandOnly);
          return this.m_CalculationType_ScotlandOnly;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_CalculationType_ScotlandOnly)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<CalculationType_ScotlandOnly>(ref this.m_CalculationType_ScotlandOnly);
        }
      }

      public CHP_Search CHP_Search
      {
        [DebuggerHidden] get
        {
          this.m_CHP_Search = MyProject.MyForms.Create__Instance__<CHP_Search>(this.m_CHP_Search);
          return this.m_CHP_Search;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_CHP_Search)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<CHP_Search>(ref this.m_CHP_Search);
        }
      }

      public Clients Clients
      {
        [DebuggerHidden] get
        {
          this.m_Clients = MyProject.MyForms.Create__Instance__<Clients>(this.m_Clients);
          return this.m_Clients;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Clients)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Clients>(ref this.m_Clients);
        }
      }

      public ConnectionCheck ConnectionCheck
      {
        [DebuggerHidden] get
        {
          this.m_ConnectionCheck = MyProject.MyForms.Create__Instance__<ConnectionCheck>(this.m_ConnectionCheck);
          return this.m_ConnectionCheck;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_ConnectionCheck)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<ConnectionCheck>(ref this.m_ConnectionCheck);
        }
      }

      public Controls Controls
      {
        [DebuggerHidden] get
        {
          this.m_Controls = MyProject.MyForms.Create__Instance__<Controls>(this.m_Controls);
          return this.m_Controls;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Controls)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Controls>(ref this.m_Controls);
        }
      }

      public Copy_Dwelling Copy_Dwelling
      {
        [DebuggerHidden] get
        {
          this.m_Copy_Dwelling = MyProject.MyForms.Create__Instance__<Copy_Dwelling>(this.m_Copy_Dwelling);
          return this.m_Copy_Dwelling;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Copy_Dwelling)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Copy_Dwelling>(ref this.m_Copy_Dwelling);
        }
      }

      public Copy_Element Copy_Element
      {
        [DebuggerHidden] get
        {
          this.m_Copy_Element = MyProject.MyForms.Create__Instance__<Copy_Element>(this.m_Copy_Element);
          return this.m_Copy_Element;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Copy_Element)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Copy_Element>(ref this.m_Copy_Element);
        }
      }

      public Copy_Multiple Copy_Multiple
      {
        [DebuggerHidden] get
        {
          this.m_Copy_Multiple = MyProject.MyForms.Create__Instance__<Copy_Multiple>(this.m_Copy_Multiple);
          return this.m_Copy_Multiple;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Copy_Multiple)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Copy_Multiple>(ref this.m_Copy_Multiple);
        }
      }

      public Copy_Opening Copy_Opening
      {
        [DebuggerHidden] get
        {
          this.m_Copy_Opening = MyProject.MyForms.Create__Instance__<Copy_Opening>(this.m_Copy_Opening);
          return this.m_Copy_Opening;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Copy_Opening)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Copy_Opening>(ref this.m_Copy_Opening);
        }
      }

      public DER_TER_Results DER_TER_Results
      {
        [DebuggerHidden] get
        {
          this.m_DER_TER_Results = MyProject.MyForms.Create__Instance__<DER_TER_Results>(this.m_DER_TER_Results);
          return this.m_DER_TER_Results;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_DER_TER_Results)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<DER_TER_Results>(ref this.m_DER_TER_Results);
        }
      }

      public Doors Doors
      {
        [DebuggerHidden] get
        {
          this.m_Doors = MyProject.MyForms.Create__Instance__<Doors>(this.m_Doors);
          return this.m_Doors;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Doors)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Doors>(ref this.m_Doors);
        }
      }

      public ECOForm ECOForm
      {
        [DebuggerHidden] get
        {
          this.m_ECOForm = MyProject.MyForms.Create__Instance__<ECOForm>(this.m_ECOForm);
          return this.m_ECOForm;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_ECOForm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<ECOForm>(ref this.m_ECOForm);
        }
      }

      public EPC_Viewer EPC_Viewer
      {
        [DebuggerHidden] get
        {
          this.m_EPC_Viewer = MyProject.MyForms.Create__Instance__<EPC_Viewer>(this.m_EPC_Viewer);
          return this.m_EPC_Viewer;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_EPC_Viewer)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<EPC_Viewer>(ref this.m_EPC_Viewer);
        }
      }

      public Error_Message Error_Message
      {
        [DebuggerHidden] get
        {
          this.m_Error_Message = MyProject.MyForms.Create__Instance__<Error_Message>(this.m_Error_Message);
          return this.m_Error_Message;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Error_Message)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Error_Message>(ref this.m_Error_Message);
        }
      }

      public FGHRS_Form FGHRS_Form
      {
        [DebuggerHidden] get
        {
          this.m_FGHRS_Form = MyProject.MyForms.Create__Instance__<FGHRS_Form>(this.m_FGHRS_Form);
          return this.m_FGHRS_Form;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_FGHRS_Form)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<FGHRS_Form>(ref this.m_FGHRS_Form);
        }
      }

      public GenResults GenResults
      {
        [DebuggerHidden] get
        {
          this.m_GenResults = MyProject.MyForms.Create__Instance__<GenResults>(this.m_GenResults);
          return this.m_GenResults;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_GenResults)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<GenResults>(ref this.m_GenResults);
        }
      }

      public HeatPump_SearchFrm HeatPump_SearchFrm
      {
        [DebuggerHidden] get
        {
          this.m_HeatPump_SearchFrm = MyProject.MyForms.Create__Instance__<HeatPump_SearchFrm>(this.m_HeatPump_SearchFrm);
          return this.m_HeatPump_SearchFrm;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_HeatPump_SearchFrm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<HeatPump_SearchFrm>(ref this.m_HeatPump_SearchFrm);
        }
      }

      public HQMHistory HQMHistory
      {
        [DebuggerHidden] get
        {
          this.m_HQMHistory = MyProject.MyForms.Create__Instance__<HQMHistory>(this.m_HQMHistory);
          return this.m_HQMHistory;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_HQMHistory)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<HQMHistory>(ref this.m_HQMHistory);
        }
      }

      public HQMLodgements HQMLodgements
      {
        [DebuggerHidden] get
        {
          this.m_HQMLodgements = MyProject.MyForms.Create__Instance__<HQMLodgements>(this.m_HQMLodgements);
          return this.m_HQMLodgements;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_HQMLodgements)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<HQMLodgements>(ref this.m_HQMLodgements);
        }
      }

      public Htb_Calculator2012 Htb_Calculator2012
      {
        [DebuggerHidden] get
        {
          this.m_Htb_Calculator2012 = MyProject.MyForms.Create__Instance__<Htb_Calculator2012>(this.m_Htb_Calculator2012);
          return this.m_Htb_Calculator2012;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Htb_Calculator2012)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Htb_Calculator2012>(ref this.m_Htb_Calculator2012);
        }
      }

      public Import2005 Import2005
      {
        [DebuggerHidden] get
        {
          this.m_Import2005 = MyProject.MyForms.Create__Instance__<Import2005>(this.m_Import2005);
          return this.m_Import2005;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Import2005)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Import2005>(ref this.m_Import2005);
        }
      }

      public Import2009Frm Import2009Frm
      {
        [DebuggerHidden] get
        {
          this.m_Import2009Frm = MyProject.MyForms.Create__Instance__<Import2009Frm>(this.m_Import2009Frm);
          return this.m_Import2009Frm;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Import2009Frm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Import2009Frm>(ref this.m_Import2009Frm);
        }
      }

      public Import2012Frm Import2012Frm
      {
        [DebuggerHidden] get
        {
          this.m_Import2012Frm = MyProject.MyForms.Create__Instance__<Import2012Frm>(this.m_Import2012Frm);
          return this.m_Import2012Frm;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Import2012Frm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Import2012Frm>(ref this.m_Import2012Frm);
        }
      }

      public Key_Results Key_Results
      {
        [DebuggerHidden] get
        {
          this.m_Key_Results = MyProject.MyForms.Create__Instance__<Key_Results>(this.m_Key_Results);
          return this.m_Key_Results;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Key_Results)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Key_Results>(ref this.m_Key_Results);
        }
      }

      public Lodgement Lodgement
      {
        [DebuggerHidden] get
        {
          this.m_Lodgement = MyProject.MyForms.Create__Instance__<Lodgement>(this.m_Lodgement);
          return this.m_Lodgement;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Lodgement)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Lodgement>(ref this.m_Lodgement);
        }
      }

      public Lodgement_History Lodgement_History
      {
        [DebuggerHidden] get
        {
          this.m_Lodgement_History = MyProject.MyForms.Create__Instance__<Lodgement_History>(this.m_Lodgement_History);
          return this.m_Lodgement_History;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Lodgement_History)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Lodgement_History>(ref this.m_Lodgement_History);
        }
      }

      public Lodgement_Result Lodgement_Result
      {
        [DebuggerHidden] get
        {
          this.m_Lodgement_Result = MyProject.MyForms.Create__Instance__<Lodgement_Result>(this.m_Lodgement_Result);
          return this.m_Lodgement_Result;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Lodgement_Result)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Lodgement_Result>(ref this.m_Lodgement_Result);
        }
      }

      public Lodgements_Successful Lodgements_Successful
      {
        [DebuggerHidden] get
        {
          this.m_Lodgements_Successful = MyProject.MyForms.Create__Instance__<Lodgements_Successful>(this.m_Lodgements_Successful);
          return this.m_Lodgements_Successful;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Lodgements_Successful)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Lodgements_Successful>(ref this.m_Lodgements_Successful);
        }
      }

      public Logo Logo
      {
        [DebuggerHidden] get
        {
          this.m_Logo = MyProject.MyForms.Create__Instance__<Logo>(this.m_Logo);
          return this.m_Logo;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Logo)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Logo>(ref this.m_Logo);
        }
      }

      public Main Main
      {
        [DebuggerHidden] get
        {
          this.m_Main = MyProject.MyForms.Create__Instance__<Main>(this.m_Main);
          return this.m_Main;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Main)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Main>(ref this.m_Main);
        }
      }

      public Members_Details Members_Details
      {
        [DebuggerHidden] get
        {
          this.m_Members_Details = MyProject.MyForms.Create__Instance__<Members_Details>(this.m_Members_Details);
          return this.m_Members_Details;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Members_Details)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Members_Details>(ref this.m_Members_Details);
        }
      }

      public Monthly_Form Monthly_Form
      {
        [DebuggerHidden] get
        {
          this.m_Monthly_Form = MyProject.MyForms.Create__Instance__<Monthly_Form>(this.m_Monthly_Form);
          return this.m_Monthly_Form;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Monthly_Form)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Monthly_Form>(ref this.m_Monthly_Form);
        }
      }

      public MoveToo MoveToo
      {
        [DebuggerHidden] get
        {
          this.m_MoveToo = MyProject.MyForms.Create__Instance__<MoveToo>(this.m_MoveToo);
          return this.m_MoveToo;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_MoveToo)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<MoveToo>(ref this.m_MoveToo);
        }
      }

      public Notes Notes
      {
        [DebuggerHidden] get
        {
          this.m_Notes = MyProject.MyForms.Create__Instance__<Notes>(this.m_Notes);
          return this.m_Notes;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Notes)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Notes>(ref this.m_Notes);
        }
      }

      public Ordering Ordering
      {
        [DebuggerHidden] get
        {
          this.m_Ordering = MyProject.MyForms.Create__Instance__<Ordering>(this.m_Ordering);
          return this.m_Ordering;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Ordering)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Ordering>(ref this.m_Ordering);
        }
      }

      public Products Products
      {
        [DebuggerHidden] get
        {
          this.m_Products = MyProject.MyForms.Create__Instance__<Products>(this.m_Products);
          return this.m_Products;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Products)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Products>(ref this.m_Products);
        }
      }

      public Reports Reports
      {
        [DebuggerHidden] get
        {
          this.m_Reports = MyProject.MyForms.Create__Instance__<Reports>(this.m_Reports);
          return this.m_Reports;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Reports)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Reports>(ref this.m_Reports);
        }
      }

      public RoofWindows RoofWindows
      {
        [DebuggerHidden] get
        {
          this.m_RoofWindows = MyProject.MyForms.Create__Instance__<RoofWindows>(this.m_RoofWindows);
          return this.m_RoofWindows;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_RoofWindows)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<RoofWindows>(ref this.m_RoofWindows);
        }
      }

      public SAPForm SAPForm
      {
        [DebuggerHidden] get
        {
          this.m_SAPForm = MyProject.MyForms.Create__Instance__<SAPForm>(this.m_SAPForm);
          return this.m_SAPForm;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_SAPForm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SAPForm>(ref this.m_SAPForm);
        }
      }

      public Save Save
      {
        [DebuggerHidden] get
        {
          this.m_Save = MyProject.MyForms.Create__Instance__<Save>(this.m_Save);
          return this.m_Save;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Save)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Save>(ref this.m_Save);
        }
      }

      public Saved Saved
      {
        [DebuggerHidden] get
        {
          this.m_Saved = MyProject.MyForms.Create__Instance__<Saved>(this.m_Saved);
          return this.m_Saved;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Saved)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Saved>(ref this.m_Saved);
        }
      }

      public Shelter Shelter
      {
        [DebuggerHidden] get
        {
          this.m_Shelter = MyProject.MyForms.Create__Instance__<Shelter>(this.m_Shelter);
          return this.m_Shelter;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Shelter)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Shelter>(ref this.m_Shelter);
        }
      }

      public SingleHQM SingleHQM
      {
        [DebuggerHidden] get
        {
          this.m_SingleHQM = MyProject.MyForms.Create__Instance__<SingleHQM>(this.m_SingleHQM);
          return this.m_SingleHQM;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_SingleHQM)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SingleHQM>(ref this.m_SingleHQM);
        }
      }

      public Solid_Search Solid_Search
      {
        [DebuggerHidden] get
        {
          this.m_Solid_Search = MyProject.MyForms.Create__Instance__<Solid_Search>(this.m_Solid_Search);
          return this.m_Solid_Search;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Solid_Search)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Solid_Search>(ref this.m_Solid_Search);
        }
      }

      public Splash Splash
      {
        [DebuggerHidden] get
        {
          this.m_Splash = MyProject.MyForms.Create__Instance__<Splash>(this.m_Splash);
          return this.m_Splash;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Splash)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Splash>(ref this.m_Splash);
        }
      }

      public StorageHeaterSelection StorageHeaterSelection
      {
        [DebuggerHidden] get
        {
          this.m_StorageHeaterSelection = MyProject.MyForms.Create__Instance__<StorageHeaterSelection>(this.m_StorageHeaterSelection);
          return this.m_StorageHeaterSelection;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_StorageHeaterSelection)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<StorageHeaterSelection>(ref this.m_StorageHeaterSelection);
        }
      }

      public StorageSelectionVessel StorageSelectionVessel
      {
        [DebuggerHidden] get
        {
          this.m_StorageSelectionVessel = MyProject.MyForms.Create__Instance__<StorageSelectionVessel>(this.m_StorageSelectionVessel);
          return this.m_StorageSelectionVessel;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_StorageSelectionVessel)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<StorageSelectionVessel>(ref this.m_StorageSelectionVessel);
        }
      }

      public Trial Trial
      {
        [DebuggerHidden] get
        {
          this.m_Trial = MyProject.MyForms.Create__Instance__<Trial>(this.m_Trial);
          return this.m_Trial;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Trial)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Trial>(ref this.m_Trial);
        }
      }

      public Updates Updates
      {
        [DebuggerHidden] get
        {
          this.m_Updates = MyProject.MyForms.Create__Instance__<Updates>(this.m_Updates);
          return this.m_Updates;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Updates)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Updates>(ref this.m_Updates);
        }
      }

      public UvalueChanges UvalueChanges
      {
        [DebuggerHidden] get
        {
          this.m_UvalueChanges = MyProject.MyForms.Create__Instance__<UvalueChanges>(this.m_UvalueChanges);
          return this.m_UvalueChanges;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_UvalueChanges)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<UvalueChanges>(ref this.m_UvalueChanges);
        }
      }

      public UValues UValues
      {
        [DebuggerHidden] get
        {
          this.m_UValues = MyProject.MyForms.Create__Instance__<UValues>(this.m_UValues);
          return this.m_UValues;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_UValues)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<UValues>(ref this.m_UValues);
        }
      }

      public SAP2012.Version Version
      {
        [DebuggerHidden] get
        {
          this.m_Version = MyProject.MyForms.Create__Instance__<SAP2012.Version>(this.m_Version);
          return this.m_Version;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Version)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SAP2012.Version>(ref this.m_Version);
        }
      }

      public VersionHistroy VersionHistroy
      {
        [DebuggerHidden] get
        {
          this.m_VersionHistroy = MyProject.MyForms.Create__Instance__<VersionHistroy>(this.m_VersionHistroy);
          return this.m_VersionHistroy;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_VersionHistroy)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<VersionHistroy>(ref this.m_VersionHistroy);
        }
      }

      public WarmAirSearch WarmAirSearch
      {
        [DebuggerHidden] get
        {
          this.m_WarmAirSearch = MyProject.MyForms.Create__Instance__<WarmAirSearch>(this.m_WarmAirSearch);
          return this.m_WarmAirSearch;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_WarmAirSearch)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<WarmAirSearch>(ref this.m_WarmAirSearch);
        }
      }

      public SAP2012.Windows Windows
      {
        [DebuggerHidden] get
        {
          this.m_Windows = MyProject.MyForms.Create__Instance__<SAP2012.Windows>(this.m_Windows);
          return this.m_Windows;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Windows)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<SAP2012.Windows>(ref this.m_Windows);
        }
      }

      public Work Work
      {
        [DebuggerHidden] get
        {
          this.m_Work = MyProject.MyForms.Create__Instance__<Work>(this.m_Work);
          return this.m_Work;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Work)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Work>(ref this.m_Work);
        }
      }

      public WorkSheetView WorkSheetView
      {
        [DebuggerHidden] get
        {
          this.m_WorkSheetView = MyProject.MyForms.Create__Instance__<WorkSheetView>(this.m_WorkSheetView);
          return this.m_WorkSheetView;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_WorkSheetView)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<WorkSheetView>(ref this.m_WorkSheetView);
        }
      }

      public WWHRSForm WWHRSForm
      {
        [DebuggerHidden] get
        {
          this.m_WWHRSForm = MyProject.MyForms.Create__Instance__<WWHRSForm>(this.m_WWHRSForm);
          return this.m_WWHRSForm;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_WWHRSForm)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<WWHRSForm>(ref this.m_WWHRSForm);
        }
      }

      public XML XML
      {
        [DebuggerHidden] get
        {
          this.m_XML = MyProject.MyForms.Create__Instance__<XML>(this.m_XML);
          return this.m_XML;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_XML)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<XML>(ref this.m_XML);
        }
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override int GetHashCode() => base.GetHashCode();

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new System.Type GetType() => typeof (MyProject.MyWebServices);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new() => (object) instance == null ? new T() : instance;

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
