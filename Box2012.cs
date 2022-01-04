
// Type: SAP2012.Box2012




using System.ComponentModel;

namespace SAP2012
{
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class Box2012
  {
    private Dimensions2012 _Dimensions;
    private Ventilation2012 _Ventilation;
    private HeatLoss2012 _HeatLoss;
    private Water_heating2012 _Water_heating;
    private Internal_gains2012 _Internal_Gains;
    private Solar_gains2012 _Solar_gains;
    private Mean_Int_Temp2012 _Mean_Int_Temp;
    private Space_heating_requirement2012 _Space_heating_requirement;
    private Space_cooling_requirement2012 _Space_cooling_requirement;
    private Fabric_Energy_Efficiency2012 _Fabric_Energy_Efficiency;
    private Energy_Requirements_9a2012 _Energy_Requirements_9a;
    private Fuel_costs_10a2012 _Fuel_costs_10a;
    private SAP_rating_11a2012 _SAP_rating_11a;
    private Energy_Requirements_9b2012 _Energy_Requirements_9b;
    private Fuel_costs_10b2012 _Fuel_costs_10b;
    private SAP_rating_11b2012 _SAP_rating_11b;
    private CO2_Emissions_12a2012 _CO2_Emissions_12a;
    private CO2_Emissions_12b2012 _CO2_Emissions_12b;
    private Primary_Energy_13a2012 _Primary_Energy_13a;
    private Primary_Energy_13b2012 _Primary_Energy_13b;
    private Renewable2012 _Renewable;
    private Actual_costs_10a2012 _Actual_costs_10a;
    private Actual_costs_10b2012 _Actual_costs_10b;
    private AssessmentLZC_2012 _AssessmentLZC2012;

    public Box2012()
    {
      this._Dimensions = new Dimensions2012();
      this._Ventilation = new Ventilation2012();
      this._HeatLoss = new HeatLoss2012();
      this._Water_heating = new Water_heating2012();
      this._Internal_Gains = new Internal_gains2012();
      this._Solar_gains = new Solar_gains2012();
      this._Mean_Int_Temp = new Mean_Int_Temp2012();
      this._Space_heating_requirement = new Space_heating_requirement2012();
      this._Space_cooling_requirement = new Space_cooling_requirement2012();
      this._Fabric_Energy_Efficiency = new Fabric_Energy_Efficiency2012();
      this._Energy_Requirements_9a = new Energy_Requirements_9a2012();
      this._Fuel_costs_10a = new Fuel_costs_10a2012();
      this._SAP_rating_11a = new SAP_rating_11a2012();
      this._Energy_Requirements_9b = new Energy_Requirements_9b2012();
      this._Fuel_costs_10b = new Fuel_costs_10b2012();
      this._SAP_rating_11b = new SAP_rating_11b2012();
      this._CO2_Emissions_12a = new CO2_Emissions_12a2012();
      this._CO2_Emissions_12b = new CO2_Emissions_12b2012();
      this._Primary_Energy_13a = new Primary_Energy_13a2012();
      this._Primary_Energy_13b = new Primary_Energy_13b2012();
      this._Renewable = new Renewable2012();
      this._Actual_costs_10a = new Actual_costs_10a2012();
      this._Actual_costs_10b = new Actual_costs_10b2012();
      this._AssessmentLZC2012 = new AssessmentLZC_2012();
    }

    public override string ToString() => "Main Calculation";

    [Category("Calculation")]
    [ReadOnly(true)]
    public Dimensions2012 Dimensions => this._Dimensions;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Ventilation2012 Ventilation => this._Ventilation;

    [Category("Calculation")]
    [ReadOnly(true)]
    public HeatLoss2012 HeatLoss => this._HeatLoss;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Water_heating2012 Water_heating => this._Water_heating;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Internal_gains2012 Internal_gains => this._Internal_Gains;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Solar_gains2012 Solar_gains => this._Solar_gains;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Mean_Int_Temp2012 Mean_Int_Temp => this._Mean_Int_Temp;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Space_heating_requirement2012 Space_heating_requirement => this._Space_heating_requirement;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Space_cooling_requirement2012 Space_cooling_requirement => this._Space_cooling_requirement;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Fabric_Energy_Efficiency2012 Fabric_Energy_Efficiency => this._Fabric_Energy_Efficiency;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Energy_Requirements_9a2012 Energy_Requirements_9a => this._Energy_Requirements_9a;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Fuel_costs_10a2012 Fuel_costs_10a => this._Fuel_costs_10a;

    [Category("Calculation")]
    [ReadOnly(true)]
    public SAP_rating_11a2012 SAP_rating_11a => this._SAP_rating_11a;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Energy_Requirements_9b2012 Energy_Requirements_9b => this._Energy_Requirements_9b;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Fuel_costs_10b2012 Fuel_costs_10b => this._Fuel_costs_10b;

    [Category("Calculation")]
    [ReadOnly(true)]
    public SAP_rating_11b2012 SAP_rating_11b => this._SAP_rating_11b;

    [Category("Calculation")]
    [ReadOnly(true)]
    public CO2_Emissions_12a2012 CO2_Emissions_12a => this._CO2_Emissions_12a;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Primary_Energy_13a2012 Primary_Energy_13a => this._Primary_Energy_13a;

    [Category("Calculation")]
    [ReadOnly(true)]
    public CO2_Emissions_12b2012 CO2_Emissions_12b => this._CO2_Emissions_12b;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Primary_Energy_13b2012 Primary_Energy_13b => this._Primary_Energy_13b;

    [Category("Renewable Technology")]
    [ReadOnly(true)]
    public Renewable2012 Renewable => this._Renewable;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Actual_costs_10a2012 Actual_costs_10a => this._Actual_costs_10a;

    [Category("Calculation")]
    [ReadOnly(true)]
    public Actual_costs_10b2012 Actual_costs_10b => this._Actual_costs_10b;

    [Category("Calculation")]
    [ReadOnly(true)]
    public AssessmentLZC_2012 AssessmentLZC2012 => this._AssessmentLZC2012;
  }
}
