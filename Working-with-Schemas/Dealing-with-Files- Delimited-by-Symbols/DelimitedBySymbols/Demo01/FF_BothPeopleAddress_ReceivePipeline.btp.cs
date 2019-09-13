namespace DelimitedBySymbols
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class FF_BothPeopleAddress_ReceivePipeline : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.FFDasmComp,Micros"+
"oft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</"+
"Name>          <ComponentName>Flat file disassembler</ComponentName>          <Description>Streaming"+
" flat file disassembler component</Description>          <Version>1.0</Version>          <Properties"+
">            <Property Name=\"HeaderSpecName\" />            <Property Name=\"DocumentSpecName\">       "+
"       <Value xsi:type=\"xsd:string\">DelimitedBySymbols.FF_DSYMBOL_ADDRESS</Value>            </Prope"+
"rty>            <Property Name=\"TrailerSpecName\" />            <Property Name=\"PreserveHeader\">     "+
"         <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Nam"+
"e=\"ValidateDocumentStructure\">              <Value xsi:type=\"xsd:boolean\">false</Value>            <"+
"/Property>            <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:typ"+
"e=\"xsd:boolean\">false</Value>            </Property>          </Properties>          <CachedDisplayN"+
"ame>Flat file disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>     "+
"   </Component>        <Component>          <Name>Microsoft.BizTalk.Component.FFDasmComp,Microsoft.B"+
"izTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>"+
"          <ComponentName>Flat file disassembler</ComponentName>          <Description>Streaming flat"+
" file disassembler component</Description>          <Version>1.0</Version>          <Properties>    "+
"        <Property Name=\"HeaderSpecName\" />            <Property Name=\"DocumentSpecName\">            "+
"  <Value xsi:type=\"xsd:string\">DelimitedBySymbols.FF_DSYMBOL_PEOPLE</Value>            </Property>  "+
"          <Property Name=\"TrailerSpecName\" />            <Property Name=\"PreserveHeader\">           "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"Val"+
"idateDocumentStructure\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Prope"+
"rty>            <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd"+
":boolean\">false</Value>            </Property>          </Properties>          <CachedDisplayName>Fl"+
"at file disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </C"+
"omponent>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID"+
"=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-"+
"4a5040674ad6\" />      <Components />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name"+
"\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cc"+
"e-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "a03e31b2-1301-44fc-90fc-6ae1065ee9a2";
        
        public FF_BothPeopleAddress_ReceivePipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.FFDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"HeaderSpecName\""+
" />    <Property Name=\"DocumentSpecName\">      <Value xsi:type=\"xsd:string\">DelimitedBySymbols.FF_DS"+
"YMBOL_ADDRESS</Value>    </Property>    <Property Name=\"TrailerSpecName\" />    <Property Name=\"Prese"+
"rveHeader\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Valid"+
"ateDocumentStructure\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property "+
"Name=\"RecoverableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Prope"+
"rty>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.FFDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"HeaderSpecName\""+
" />    <Property Name=\"DocumentSpecName\">      <Value xsi:type=\"xsd:string\">DelimitedBySymbols.FF_DS"+
"YMBOL_PEOPLE</Value>    </Property>    <Property Name=\"TrailerSpecName\" />    <Property Name=\"Preser"+
"veHeader\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Valida"+
"teDocumentStructure\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property N"+
"ame=\"RecoverableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Proper"+
"ty>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
