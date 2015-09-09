//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.42.
// 
namespace Aptima.Asim.DDD.CommonComponents.SimulationModelTools.GeneratedCode {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    //[System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="SimulationModel.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="SimulationModel.xsd", IsNullable=false)]
    public partial class SimulationModelRoot {
        
        private ObjectTypeInfo[] objectModelField;
        
        private EventTypeInfo[] eventModelField;
        
        private SimulatorInfo[] simulatorModelField;
        
        private SimulationExecutionModelType simulationExecutionModelField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ObjectType", IsNullable=false)]
        public ObjectTypeInfo[] ObjectModel {
            get {
                return this.objectModelField;
            }
            set {
                this.objectModelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EventType", IsNullable=false)]
        public EventTypeInfo[] EventModel {
            get {
                return this.eventModelField;
            }
            set {
                this.eventModelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Simulator", IsNullable=false)]
        public SimulatorInfo[] SimulatorModel {
            get {
                return this.simulatorModelField;
            }
            set {
                this.simulatorModelField = value;
            }
        }
        
        /// <remarks/>
        public SimulationExecutionModelType SimulationExecutionModel {
            get {
                return this.simulationExecutionModelField;
            }
            set {
                this.simulationExecutionModelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class ObjectTypeInfo {
        
        private AttributeInfo[] attributeField;
        
        private ObjectTypeInfo[] objectTypeField;
        
        private string nameField;
        
        private bool instantiatableField;
        
        public ObjectTypeInfo() {
            this.instantiatableField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attribute")]
        public AttributeInfo[] Attribute {
            get {
                return this.attributeField;
            }
            set {
                this.attributeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObjectType")]
        public ObjectTypeInfo[] ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Instantiatable {
            get {
                return this.instantiatableField;
            }
            set {
                this.instantiatableField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class AttributeInfo {
        
        private string nameField;
        
        private DataTypeNames dataTypeField;
        
        private bool ownerObservableField;
        
        private bool otherObservableField;
        
        private bool excludeFromScenarioField;
        
        public AttributeInfo() {
            this.ownerObservableField = false;
            this.otherObservableField = false;
            this.excludeFromScenarioField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataTypeNames DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool OwnerObservable {
            get {
                return this.ownerObservableField;
            }
            set {
                this.ownerObservableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool OtherObservable {
            get {
                return this.otherObservableField;
            }
            set {
                this.otherObservableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ExcludeFromScenario {
            get {
                return this.excludeFromScenarioField;
            }
            set {
                this.excludeFromScenarioField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public enum DataTypeNames {
        
        /// <remarks/>
        WrapperType,

        /// <remarks/>
        StringType,
        
        /// <remarks/>
        DoubleType,
        
        /// <remarks/>
        IntegerType,
        
        /// <remarks/>
        BooleanType,
        
        /// <remarks/>
        LocationType,
        
        /// <remarks/>
        VelocityType,
        
        /// <remarks/>
        AttributeCollectionType,
        
        /// <remarks/>
        StateTableType,
        
        /// <remarks/>
        CapabilityType,
        
        /// <remarks/>
        VulnerabilityType,
        
        /// <remarks/>
        StringListType,
        
        /// <remarks/>
        PolygonType,
        
        /// <remarks/>
        SensorArrayType,
        
        /// <remarks/>
        SensorType,
        
        /// <remarks/>
        ConeType,
        
        /// <remarks/>
        EmitterType,
        
        /// <remarks/>
        CustomAttributesType,
        
        /// <remarks/>
        RangeRingDisplayType,
        
        /// <remarks/>
        AttackCollectionType,

        /// <remarks/>
        ClassificationDisplayRulesType,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class SimulatorExecution {
        
        private string simulatorNameField;
        
        private string dLLNameField;
        
        /// <remarks/>
        public string SimulatorName {
            get {
                return this.simulatorNameField;
            }
            set {
                this.simulatorNameField = value;
            }
        }
        
        /// <remarks/>
        public string DLLName {
            get {
                return this.dLLNameField;
            }
            set {
                this.dLLNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class SimulationExecutionModelType {
        
        private SimulatorExecution[] simulatorField;
        
        private int updateFrequencyField;
        
        private bool updateFrequencyFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Simulator")]
        public SimulatorExecution[] Simulator {
            get {
                return this.simulatorField;
            }
            set {
                this.simulatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int UpdateFrequency {
            get {
                return this.updateFrequencyField;
            }
            set {
                this.updateFrequencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateFrequencySpecified {
            get {
                return this.updateFrequencyFieldSpecified;
            }
            set {
                this.updateFrequencyFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class EventSubscription {
        
        private string nameField;
        
        private bool publishField;
        
        private bool subscribeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Publish {
            get {
                return this.publishField;
            }
            set {
                this.publishField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Subscribe {
            get {
                return this.subscribeField;
            }
            set {
                this.subscribeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class AttributeSubscription {
        
        private string nameField;
        
        private bool publishField;
        
        private bool subscribeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Publish {
            get {
                return this.publishField;
            }
            set {
                this.publishField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Subscribe {
            get {
                return this.subscribeField;
            }
            set {
                this.subscribeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class ObjectInfo {
        
        private AttributeSubscription[] attributeNameField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeName")]
        public AttributeSubscription[] AttributeName {
            get {
                return this.attributeNameField;
            }
            set {
                this.attributeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class SimulatorInfo {
        
        private ObjectInfo[] objectNameField;
        
        private EventSubscription[] eventNameField;
        
        private string descriptionField;
        
        private string nameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ObjectName")]
        public ObjectInfo[] ObjectName {
            get {
                return this.objectNameField;
            }
            set {
                this.objectNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventName")]
        public EventSubscription[] EventName {
            get {
                return this.eventNameField;
            }
            set {
                this.eventNameField = value;
            }
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class ParameterInfo {
        
        private string nameField;
        
        private DataTypeNames dataTypeField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataTypeNames DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="SimulationModel.xsd")]
    public partial class EventTypeInfo {
        
        private string descriptionField;
        
        private ParameterInfo[] parameterField;
        
        private EventTypeInfo[] eventTypeField;
        
        private string nameField;
        
        private bool logField;
        
        private bool replayField;
        
        private bool forkReplayField;
        
        private bool simCoreSubscribeField;
        
        public EventTypeInfo() {
            this.logField = true;
            this.replayField = false;
            this.forkReplayField = false;
            this.simCoreSubscribeField = true;
        }
        
        /// <remarks/>
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterInfo[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EventType")]
        public EventTypeInfo[] EventType {
            get {
                return this.eventTypeField;
            }
            set {
                this.eventTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Log {
            get {
                return this.logField;
            }
            set {
                this.logField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Replay {
            get {
                return this.replayField;
            }
            set {
                this.replayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ForkReplay {
            get {
                return this.forkReplayField;
            }
            set {
                this.forkReplayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool SimCoreSubscribe {
            get {
                return this.simCoreSubscribeField;
            }
            set {
                this.simCoreSubscribeField = value;
            }
        }
    }
}