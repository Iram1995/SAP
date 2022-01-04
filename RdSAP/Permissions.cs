
// Type: SAP2012.RdSAP.Permissions




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "Permissions", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class Permissions : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private bool Can_ChangePasswordField;
    [OptionalField]
    private bool Can_CreateField;
    [OptionalField]
    private bool Can_ImportXMLField;
    [OptionalField]
    private bool Can_LodgeField;
    [OptionalField]
    private bool Can_OpenOnlineField;
    [OptionalField]
    private bool Can_SaveOnlineField;
    [OptionalField]
    private bool Can_SeeStackField;
    [OptionalField]
    private bool Can_SelectPCDFField;
    [OptionalField]
    private bool Can_UpdateAddressField;
    [OptionalField]
    private bool Has_AdminField;
    [OptionalField]
    private bool Has_ECOField;
    [OptionalField]
    private bool Has_EPCField;
    [OptionalField]
    private bool Has_GreenDealField;
    [OptionalField]
    private bool Has_OAField;
    [OptionalField]
    private bool Require_PasswordChangeField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public bool Can_ChangePassword
    {
      get => this.Can_ChangePasswordField;
      set
      {
        if (this.Can_ChangePasswordField.Equals(value))
          return;
        this.Can_ChangePasswordField = value;
        this.RaisePropertyChanged(nameof (Can_ChangePassword));
      }
    }

    [DataMember]
    public bool Can_Create
    {
      get => this.Can_CreateField;
      set
      {
        if (this.Can_CreateField.Equals(value))
          return;
        this.Can_CreateField = value;
        this.RaisePropertyChanged(nameof (Can_Create));
      }
    }

    [DataMember]
    public bool Can_ImportXML
    {
      get => this.Can_ImportXMLField;
      set
      {
        if (this.Can_ImportXMLField.Equals(value))
          return;
        this.Can_ImportXMLField = value;
        this.RaisePropertyChanged(nameof (Can_ImportXML));
      }
    }

    [DataMember]
    public bool Can_Lodge
    {
      get => this.Can_LodgeField;
      set
      {
        if (this.Can_LodgeField.Equals(value))
          return;
        this.Can_LodgeField = value;
        this.RaisePropertyChanged(nameof (Can_Lodge));
      }
    }

    [DataMember]
    public bool Can_OpenOnline
    {
      get => this.Can_OpenOnlineField;
      set
      {
        if (this.Can_OpenOnlineField.Equals(value))
          return;
        this.Can_OpenOnlineField = value;
        this.RaisePropertyChanged(nameof (Can_OpenOnline));
      }
    }

    [DataMember]
    public bool Can_SaveOnline
    {
      get => this.Can_SaveOnlineField;
      set
      {
        if (this.Can_SaveOnlineField.Equals(value))
          return;
        this.Can_SaveOnlineField = value;
        this.RaisePropertyChanged(nameof (Can_SaveOnline));
      }
    }

    [DataMember]
    public bool Can_SeeStack
    {
      get => this.Can_SeeStackField;
      set
      {
        if (this.Can_SeeStackField.Equals(value))
          return;
        this.Can_SeeStackField = value;
        this.RaisePropertyChanged(nameof (Can_SeeStack));
      }
    }

    [DataMember]
    public bool Can_SelectPCDF
    {
      get => this.Can_SelectPCDFField;
      set
      {
        if (this.Can_SelectPCDFField.Equals(value))
          return;
        this.Can_SelectPCDFField = value;
        this.RaisePropertyChanged(nameof (Can_SelectPCDF));
      }
    }

    [DataMember]
    public bool Can_UpdateAddress
    {
      get => this.Can_UpdateAddressField;
      set
      {
        if (this.Can_UpdateAddressField.Equals(value))
          return;
        this.Can_UpdateAddressField = value;
        this.RaisePropertyChanged(nameof (Can_UpdateAddress));
      }
    }

    [DataMember]
    public bool Has_Admin
    {
      get => this.Has_AdminField;
      set
      {
        if (this.Has_AdminField.Equals(value))
          return;
        this.Has_AdminField = value;
        this.RaisePropertyChanged(nameof (Has_Admin));
      }
    }

    [DataMember]
    public bool Has_ECO
    {
      get => this.Has_ECOField;
      set
      {
        if (this.Has_ECOField.Equals(value))
          return;
        this.Has_ECOField = value;
        this.RaisePropertyChanged(nameof (Has_ECO));
      }
    }

    [DataMember]
    public bool Has_EPC
    {
      get => this.Has_EPCField;
      set
      {
        if (this.Has_EPCField.Equals(value))
          return;
        this.Has_EPCField = value;
        this.RaisePropertyChanged(nameof (Has_EPC));
      }
    }

    [DataMember]
    public bool Has_GreenDeal
    {
      get => this.Has_GreenDealField;
      set
      {
        if (this.Has_GreenDealField.Equals(value))
          return;
        this.Has_GreenDealField = value;
        this.RaisePropertyChanged(nameof (Has_GreenDeal));
      }
    }

    [DataMember]
    public bool Has_OA
    {
      get => this.Has_OAField;
      set
      {
        if (this.Has_OAField.Equals(value))
          return;
        this.Has_OAField = value;
        this.RaisePropertyChanged(nameof (Has_OA));
      }
    }

    [DataMember]
    public bool Require_PasswordChange
    {
      get => this.Require_PasswordChangeField;
      set
      {
        if (this.Require_PasswordChangeField.Equals(value))
          return;
        this.Require_PasswordChangeField = value;
        this.RaisePropertyChanged(nameof (Require_PasswordChange));
      }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void RaisePropertyChanged(string propertyName)
    {
      // ISSUE: reference to a compiler-generated field
      PropertyChangedEventHandler propertyChangedEvent = this.PropertyChangedEvent;
      if (propertyChangedEvent == null)
        return;
      propertyChangedEvent((object) this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
