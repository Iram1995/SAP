
// Type: SAP2012.RdSAP.RdSAPNews




using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace SAP2012.RdSAP
{
  [DebuggerStepThrough]
  [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
  [DataContract(Name = "RdSAPNews", Namespace = "http://schemas.datacontract.org/2004/07/StromaServices")]
  [Serializable]
  public class RdSAPNews : IExtensibleDataObject, INotifyPropertyChanged
  {
    [NonSerialized]
    private ExtensionDataObject extensionDataField;
    [OptionalField]
    private string News_ContentField;
    [OptionalField]
    private string News_DateField;
    [OptionalField]
    private string News_TitleField;

    [Browsable(false)]
    public ExtensionDataObject ExtensionData
    {
      get => this.extensionDataField;
      set => this.extensionDataField = value;
    }

    [DataMember]
    public string News_Content
    {
      get => this.News_ContentField;
      set
      {
        if (object.ReferenceEquals((object) this.News_ContentField, (object) value))
          return;
        this.News_ContentField = value;
        this.RaisePropertyChanged(nameof (News_Content));
      }
    }

    [DataMember]
    public string News_Date
    {
      get => this.News_DateField;
      set
      {
        if (object.ReferenceEquals((object) this.News_DateField, (object) value))
          return;
        this.News_DateField = value;
        this.RaisePropertyChanged(nameof (News_Date));
      }
    }

    [DataMember]
    public string News_Title
    {
      get => this.News_TitleField;
      set
      {
        if (object.ReferenceEquals((object) this.News_TitleField, (object) value))
          return;
        this.News_TitleField = value;
        this.RaisePropertyChanged(nameof (News_Title));
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
