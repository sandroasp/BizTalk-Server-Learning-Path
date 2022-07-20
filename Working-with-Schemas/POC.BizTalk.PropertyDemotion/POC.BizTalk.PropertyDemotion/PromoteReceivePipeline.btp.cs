namespace POC.BizTalk.PropertyDemotion
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class PromoteReceivePipeline : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>POC.BizTalk.PropertyDemotion.PipelineComponent.BizTalkPromotion"+
",POC.BizTalk.PropertyDemotion.PipelineComponent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=5c"+
"91f4a242f7c184</Name>          <ComponentName>Promotion Component</ComponentName>          <Descript"+
"ion>Promotion Pipeline Component</Description>          <Version>1.0</Version>          <Properties "+
"/>          <CachedDisplayName>Promotion Component</CachedDisplayName>          <CachedIsManaged>tru"+
"e</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileSt"+
"age _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"First"+
"Match\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" />      <Components>        <Component>       "+
"   <Name>Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0."+
"1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <ComponentName>XML disassemble"+
"r</ComponentName>          <Description>Streaming XML disassembler</Description>          <Version>1"+
".0</Version>          <Properties>            <Property Name=\"EnvelopeSpecNames\">              <Valu"+
"e xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"EnvelopeSpecTargetNames"+
"paces\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Property Nam"+
"e=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\" />            </Property>          "+
"  <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />       "+
"     </Property>            <Property Name=\"AllowUnrecognizedMessage\">              <Value xsi:type="+
"\"xsd:boolean\">false</Value>            </Property>            <Property Name=\"ValidateDocument\">    "+
"          <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property Na"+
"me=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:boolean\">false</Value>     "+
"       </Property>            <Property Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:s"+
"tring\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Value>            </Property>     "+
"       <Property Name=\"DtdProcessing\">              <Value xsi:type=\"xsd:string\" />            </Pro"+
"perty>          </Properties>          <CachedDisplayName>XML disassembler</CachedDisplayName>      "+
"    <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <S"+
"tage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\""+
"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stag"+
"e>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\""+
" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components "+
"/>    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "6efd6e8b-d9a6-4dc2-b7aa-76deaed7e142";
        
        public PromoteReceivePipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("POC.BizTalk.PropertyDemotion.PipelineComponent.BizTalkPromotion,POC.BizTalk.PropertyDemotion.PipelineComponent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=5c91f4a242f7c184");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\"> "+
"     <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"AllowUnrecognizedMessage\">   "+
"   <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\"> "+
"     <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInterc"+
"hangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name="+
"\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTarge"+
"tNamespaces</Value>    </Property>    <Property Name=\"DtdProcessing\">      <Value xsi:type=\"xsd:stri"+
"ng\" />    </Property>  </Properties></PropertyBag>";
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
