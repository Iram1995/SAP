
// Type: SAP2012.Htb_Junction




using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace SAP2012
{
  [DesignerGenerated]
  public class Htb_Junction : UserControl, IComponentConnector
  {
    public int Num;
    public Htb_Junction.JunctionType JuncType;
    public SAP_Module.Junction Junction;
    public Htb_Calculator2012 topForm;
    private bool _contentLoaded;

    public Htb_Junction() => this.InitializeComponent();

    public void CheckValues()
    {
      if (!(this.Junction.Defaul == 0.0 & this.Junction.Accredited == 0.0))
        return;
      JunctionDetail junctionDetail = SAP_Module.Junctions.Where<JunctionDetail>((Func<JunctionDetail, bool>) (b => b.Ref.Equals(this.Junction.Ref))).SingleOrDefault<JunctionDetail>();
      if (junctionDetail != null)
      {
        this.Junction.Defaul = Math.Round((double) junctionDetail.DefaultValue, 2);
        this.Junction.Accredited = Math.Round((double) junctionDetail.Approved, 2);
        if (this.JuncType == Htb_Junction.JunctionType.External)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num] = this.Junction;
        else if (this.JuncType == Htb_Junction.JunctionType.Party)
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num] = this.Junction;
        else
          SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num] = this.Junction;
      }
    }

    private void txtThermal_TextChanged(object sender, TextChangedEventArgs e)
    {
      this.Junction.ThermalTransmittance = (float) Conversion.Val(this.txtThermal.Text);
      this.txtResult.Text = Conversions.ToString(this.Junction.ThermalTransmittance * this.Junction.Length);
      if (this.JuncType == Htb_Junction.JunctionType.External)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num] = this.Junction;
      else if (this.JuncType == Htb_Junction.JunctionType.Party)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num] = this.Junction;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num] = this.Junction;
      this.ReCalc();
    }

    private void txtLength_TextChanged(object sender, TextChangedEventArgs e)
    {
      this.Junction.Length = (float) Conversion.Val(this.txtLength.Text);
      this.txtResult.Text = Conversions.ToString(this.Junction.ThermalTransmittance * this.Junction.Length);
      if (this.JuncType == Htb_Junction.JunctionType.External)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num] = this.Junction;
      else if (this.JuncType == Htb_Junction.JunctionType.Party)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num] = this.Junction;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num] = this.Junction;
      this.ReCalc();
    }

    private void ReCalc() => this.topForm.TotalIt();

    private void cmdDelete_Click(object sender, RoutedEventArgs e)
    {
      if (Interaction.MsgBox((object) ("Do you want to remove " + this.Junction.JunctionDetail + "?"), MsgBoxStyle.YesNo, (object) "Delete?") != MsgBoxResult.Yes)
        return;
      if (this.JuncType == Htb_Junction.JunctionType.External)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions.Remove(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num]);
      else if (this.JuncType == Htb_Junction.JunctionType.Party)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions.Remove(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num]);
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions.Remove(SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num]);
      object Instance = (object) this.Parent;
      while (!(Instance is Htb_Calc))
        Instance = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Instance, (System.Type) null, "parent", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ((Htb_Calc) Instance).PopJunctions();
    }

    private void IsAccredited_Checked(object sender, RoutedEventArgs e)
    {
      if (this.Junction.Accredited == 0.0)
        return;
      this.Junction.IsAccredited = this.IsAccredited.IsChecked.Value;
      this.Junction.IsDefault = false;
      this.IsDefault.IsChecked = new bool?(false);
      this.txtThermal.IsEnabled = false;
      this.txtThermal.Text = Conversions.ToString(this.Junction.Accredited);
      if (this.JuncType == Htb_Junction.JunctionType.External)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num] = this.Junction;
        string str = this.Junction.Ref;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
        {
          case 2399025958:
            if (Operators.CompareString(str, "E24", false) == 0)
              break;
            goto default;
          case 2415656482:
            if (Operators.CompareString(str, "E15", false) == 0)
              break;
            goto default;
          case 2415803577:
            if (Operators.CompareString(str, "E25", false) == 0)
              break;
            goto default;
          case 2432434101:
            if (Operators.CompareString(str, "E14", false) == 0)
              break;
            goto default;
          case 2432581196:
            if (Operators.CompareString(str, "E22", false) == 0)
              break;
            goto default;
          case 2449358815:
            if (Operators.CompareString(str, "E23", false) == 0)
              break;
            goto default;
          case 2466136434:
            if (Operators.CompareString(str, "E20", false) == 0)
              break;
            goto default;
          case 2482766958:
            if (Operators.CompareString(str, "E19", false) == 0)
              break;
            goto default;
          case 2482914053:
            if (Operators.CompareString(str, "E21", false) == 0)
              break;
            goto default;
          default:
label_13:
            string Left = this.Junction.Ref;
            if (Operators.CompareString(Left, "E1", false) == 0 || Operators.CompareString(Left, "E2", false) == 0 || Operators.CompareString(Left, "E3", false) == 0 || Operators.CompareString(Left, "E4", false) == 0)
              this.ImportLen.IsEnabled = true;
            goto label_16;
        }
        this.IsAccredited.IsChecked = new bool?(false);
        this.IsAccredited.IsEnabled = false;
        goto label_13;
      }
label_16:
      if (this.JuncType == Htb_Junction.JunctionType.Party)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num] = this.Junction;
        string str = this.Junction.Ref;
        // ISSUE: reference to a compiler-generated method
        switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
        {
          case 419422997:
            if (Operators.CompareString(str, "P8", false) == 0)
              break;
            goto default;
          case 436200616:
            if (Operators.CompareString(str, "P7", false) == 0)
              break;
            goto default;
          case 452978235:
            if (Operators.CompareString(str, "P6", false) == 0)
              break;
            goto default;
          case 469755854:
            if (Operators.CompareString(str, "P5", false) == 0)
              break;
            goto default;
          case 486533473:
            if (Operators.CompareString(str, "P4", false) == 0)
              break;
            goto default;
          case 503311092:
            if (Operators.CompareString(str, "P3", false) == 0)
              break;
            goto default;
          case 520088711:
            if (Operators.CompareString(str, "P2", false) == 0)
              break;
            goto default;
          case 536866330:
            if (Operators.CompareString(str, "P1", false) == 0)
              break;
            goto default;
          default:
label_28:
            goto label_29;
        }
        this.IsAccredited.IsChecked = new bool?(false);
        this.IsAccredited.IsEnabled = false;
        goto label_28;
      }
label_29:
      if (this.JuncType == Htb_Junction.JunctionType.Roof)
      {
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num] = this.Junction;
        this.IsAccredited.IsChecked = new bool?(false);
        this.IsAccredited.IsEnabled = false;
      }
      this.ReCalc();
    }

    private void IsDefault_Checked(object sender, RoutedEventArgs e)
    {
      this.Junction.IsAccredited = false;
      this.Junction.IsDefault = true;
      this.IsAccredited.IsChecked = new bool?(false);
      this.txtThermal.IsEnabled = false;
      this.txtThermal.Text = Conversions.ToString(this.Junction.Defaul);
      if (this.JuncType == Htb_Junction.JunctionType.External)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num] = this.Junction;
      else if (this.JuncType == Htb_Junction.JunctionType.Party)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num] = this.Junction;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num] = this.Junction;
      this.ReCalc();
    }

    private void IsAccredited_Unchecked(object sender, RoutedEventArgs e)
    {
      bool? nullable = this.IsDefault.IsChecked;
      nullable = nullable.HasValue ? new bool?(!nullable.GetValueOrDefault()) : new bool?();
      if (nullable.GetValueOrDefault())
        this.txtThermal.IsEnabled = true;
      this.Junction.IsAccredited = false;
      if (this.JuncType == Htb_Junction.JunctionType.External)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num] = this.Junction;
      else if (this.JuncType == Htb_Junction.JunctionType.Party)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num] = this.Junction;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num] = this.Junction;
    }

    private void IsDefault_Unchecked(object sender, RoutedEventArgs e)
    {
      bool? nullable = this.IsAccredited.IsChecked;
      nullable = nullable.HasValue ? new bool?(!nullable.GetValueOrDefault()) : new bool?();
      if (nullable.GetValueOrDefault())
        this.txtThermal.IsEnabled = true;
      this.Junction.IsDefault = false;
      if (this.JuncType == Htb_Junction.JunctionType.External)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.ExternalJunctions[this.Num] = this.Junction;
      else if (this.JuncType == Htb_Junction.JunctionType.Party)
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.PartyJunctions[this.Num] = this.Junction;
      else
        SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Thermal.RoofJunctions[this.Num] = this.Junction;
    }

    private void ImportLen_Click(object sender, RoutedEventArgs e)
    {
      double num1 = 0.0;
      if (this.JuncType == Htb_Junction.JunctionType.External)
      {
        string Left = this.Junction.Ref;
        if (Operators.CompareString(Left, "E1", false) != 0 && Operators.CompareString(Left, "E2", false) != 0)
        {
          if (Operators.CompareString(Left, "E3", false) != 0)
          {
            if (Operators.CompareString(Left, "E4", false) == 0)
            {
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows > 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows != null)
              {
                int num2 = checked (((IEnumerable<SAP_Module.Window>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows).Count<SAP_Module.Window>() - 1);
                int index = 0;
                while (index <= num2)
                {
                  num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index].Height * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index].Count;
                  checked { ++index; }
                }
              }
              if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors > 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors != null)
              {
                int num3 = checked (((IEnumerable<SAP_Module.Door>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors).Count<SAP_Module.Door>() - 1);
                int index = 0;
                while (index <= num3)
                {
                  num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index].Height * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index].Count;
                  checked { ++index; }
                }
              }
              num1 *= 2.0;
            }
          }
          else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows > 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows != null)
          {
            int num4 = checked (((IEnumerable<SAP_Module.Window>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows).Count<SAP_Module.Window>() - 1);
            int index = 0;
            while (index <= num4)
            {
              num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index].Width * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index].Count;
              checked { ++index; }
            }
          }
        }
        else
        {
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofWindows > 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows != null)
          {
            int num5 = checked (((IEnumerable<SAP_Module.Window>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows).Count<SAP_Module.Window>() - 1);
            int index = 0;
            while (index <= num5)
            {
              num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index].Width * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Windows[index].Count;
              checked { ++index; }
            }
          }
          if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofDoors > 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors != null)
          {
            int num6 = checked (((IEnumerable<SAP_Module.Door>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors).Count<SAP_Module.Door>() - 1);
            int index = 0;
            while (index <= num6)
            {
              num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index].Width * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].Doors[index].Count;
              checked { ++index; }
            }
          }
        }
      }
      if (this.JuncType == Htb_Junction.JunctionType.Roof)
      {
        string Left = this.Junction.Ref;
        if (Operators.CompareString(Left, "R1", false) != 0 && Operators.CompareString(Left, "R2", false) != 0)
        {
          if (Operators.CompareString(Left, "R3", false) == 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights > 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights != null)
          {
            int num7 = checked (((IEnumerable<SAP_Module.RoofLight>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights).Count<SAP_Module.RoofLight>() - 1);
            int index = 0;
            while (index <= num7)
            {
              num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Height * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Count;
              checked { ++index; }
            }
            num1 *= 2.0;
          }
        }
        else if (SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].NoofRoofLights > 0 && SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights != null)
        {
          int num8 = checked (((IEnumerable<SAP_Module.RoofLight>) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights).Count<SAP_Module.RoofLight>() - 1);
          int index = 0;
          while (index <= num8)
          {
            num1 += (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Width * (double) SAP_Module.Proj.Dwellings[SAP_Module.CurrDwelling].RoofLights[index].Count;
            checked { ++index; }
          }
        }
      }
      this.txtLength.Text = Conversions.ToString(num1 / 1000.0);
      this.ReCalc();
    }

    [field: AccessedThroughProperty("txtDescription")]
    internal virtual TextBlock txtDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtAccredited")]
    internal virtual TextBlock txtAccredited { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtResult")]
    internal virtual TextBlock txtResult { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [field: AccessedThroughProperty("txtDefault")]
    internal virtual TextBlock txtDefault { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox IsAccredited
    {
      get => this._IsAccredited;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler1 = new RoutedEventHandler(this.IsAccredited_Checked);
        RoutedEventHandler routedEventHandler2 = new RoutedEventHandler(this.IsAccredited_Unchecked);
        CheckBox isAccredited1 = this._IsAccredited;
        if (isAccredited1 != null)
        {
          isAccredited1.Checked -= routedEventHandler1;
          isAccredited1.Unchecked -= routedEventHandler2;
        }
        this._IsAccredited = value;
        CheckBox isAccredited2 = this._IsAccredited;
        if (isAccredited2 == null)
          return;
        isAccredited2.Checked += routedEventHandler1;
        isAccredited2.Unchecked += routedEventHandler2;
      }
    }

    internal virtual CheckBox IsDefault
    {
      get => this._IsDefault;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler1 = new RoutedEventHandler(this.IsDefault_Checked);
        RoutedEventHandler routedEventHandler2 = new RoutedEventHandler(this.IsDefault_Unchecked);
        CheckBox isDefault1 = this._IsDefault;
        if (isDefault1 != null)
        {
          isDefault1.Checked -= routedEventHandler1;
          isDefault1.Unchecked -= routedEventHandler2;
        }
        this._IsDefault = value;
        CheckBox isDefault2 = this._IsDefault;
        if (isDefault2 == null)
          return;
        isDefault2.Checked += routedEventHandler1;
        isDefault2.Unchecked += routedEventHandler2;
      }
    }

    internal virtual TextBox txtThermal
    {
      get => this._txtThermal;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TextChangedEventHandler changedEventHandler = new TextChangedEventHandler(this.txtThermal_TextChanged);
        TextBox txtThermal1 = this._txtThermal;
        if (txtThermal1 != null)
          txtThermal1.TextChanged -= changedEventHandler;
        this._txtThermal = value;
        TextBox txtThermal2 = this._txtThermal;
        if (txtThermal2 == null)
          return;
        txtThermal2.TextChanged += changedEventHandler;
      }
    }

    internal virtual TextBox txtLength
    {
      get => this._txtLength;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        TextChangedEventHandler changedEventHandler = new TextChangedEventHandler(this.txtLength_TextChanged);
        TextBox txtLength1 = this._txtLength;
        if (txtLength1 != null)
          txtLength1.TextChanged -= changedEventHandler;
        this._txtLength = value;
        TextBox txtLength2 = this._txtLength;
        if (txtLength2 == null)
          return;
        txtLength2.TextChanged += changedEventHandler;
      }
    }

    internal virtual Button cmdDelete
    {
      get => this._cmdDelete;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.cmdDelete_Click);
        Button cmdDelete1 = this._cmdDelete;
        if (cmdDelete1 != null)
          cmdDelete1.Click -= routedEventHandler;
        this._cmdDelete = value;
        Button cmdDelete2 = this._cmdDelete;
        if (cmdDelete2 == null)
          return;
        cmdDelete2.Click += routedEventHandler;
      }
    }

    internal virtual Button ImportLen
    {
      get => this._ImportLen;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        RoutedEventHandler routedEventHandler = new RoutedEventHandler(this.ImportLen_Click);
        Button importLen1 = this._ImportLen;
        if (importLen1 != null)
          importLen1.Click -= routedEventHandler;
        this._ImportLen = value;
        Button importLen2 = this._ImportLen;
        if (importLen2 == null)
          return;
        importLen2.Click += routedEventHandler;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/SAP2012;component/wpf%20elelemts/htb_junction.xaml", UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.txtDescription = (TextBlock) target;
          break;
        case 2:
          this.txtAccredited = (TextBlock) target;
          break;
        case 3:
          this.txtResult = (TextBlock) target;
          break;
        case 4:
          this.txtDefault = (TextBlock) target;
          break;
        case 5:
          this.IsAccredited = (CheckBox) target;
          break;
        case 6:
          this.IsDefault = (CheckBox) target;
          break;
        case 7:
          this.txtThermal = (TextBox) target;
          break;
        case 8:
          this.txtLength = (TextBox) target;
          break;
        case 9:
          this.cmdDelete = (Button) target;
          break;
        case 10:
          this.ImportLen = (Button) target;
          break;
        default:
          this._contentLoaded = true;
          break;
      }
    }

    public enum JunctionType
    {
      External,
      Party,
      Roof,
    }
  }
}
