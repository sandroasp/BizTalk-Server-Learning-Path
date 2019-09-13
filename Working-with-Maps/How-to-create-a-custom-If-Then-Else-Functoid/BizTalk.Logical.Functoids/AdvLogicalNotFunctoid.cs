using Microsoft.BizTalk.BaseFunctoids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BizTalk.Logical.Functoids
{
    [Serializable]
    public class AdvLogicalNotFunctoid : BaseFunctoid
    {
        public AdvLogicalNotFunctoid()
        {
            //ID for this functoid
            this.ID = 10908;

            // resource assembly must be ProjectName.ResourceName if building with VS.Net
            this.SetupResourceAssembly("BizTalk.Logical.Functoids.LogicalResources", Assembly.GetExecutingAssembly());

            //Setup the Name, ToolTip, Help Description, and the Bitmap for this functoid
            SetName("IDS_ADVLOGICALNOT_NAME");
            SetTooltip("IDS_ADVLOGICALNOT_TOOLTIP");
            SetDescription("IDS_ADVLOGICALNOT_DESCRIPTION");
            SetBitmap("IDB_ADVLOGICALNOT");

            //Set the function name that is to be called when invoking this functoid.
            // To test the map in Visual Studio, this functoid does not need to be in the GAC.
            // If using this functoid in a deployed BizTalk app. then it must be in the GAC
            base.SetScriptBuffer(ScriptType.CSharp, this.GetCSharpBuffer());

            base.RequiredGlobalHelperFunctions = InlineGlobalHelperFunction.ValToBool | InlineGlobalHelperFunction.IsNumeric;
            base.Category = FunctoidCategory.Logical;
            base.OutputConnectionType = ConnectionType.FunctoidString | ConnectionType.Element | ConnectionType.FunctoidAssert | ConnectionType.FunctoidNilValue | ConnectionType.FunctoidKeyMatch | ConnectionType.FunctoidTableLooping | ConnectionType.FunctoidValueMapping | ConnectionType.FunctoidScripter | ConnectionType.FunctoidLogical;
            base.HasSideEffects = false;
            base.AddInputConnectionType(ConnectionType.AllExceptRecord);
        }

        private string GetCSharpBuffer()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("public bool LogicalNot(string val)\n");
            builder.Append("{\n");
            builder.Append("\treturn !ValToBool(val);\n");
            builder.Append("}\n");
            return builder.ToString();
        }
    }
}
