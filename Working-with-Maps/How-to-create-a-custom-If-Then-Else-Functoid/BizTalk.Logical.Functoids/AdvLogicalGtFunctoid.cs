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
    public class AdvLogicalGtFunctoid : BaseFunctoid
    {
        public AdvLogicalGtFunctoid()
        {
            //ID for this functoid
            this.ID = 10905;

            // resource assembly must be ProjectName.ResourceName if building with VS.Net
            this.SetupResourceAssembly("BizTalk.Logical.Functoids.LogicalResources", Assembly.GetExecutingAssembly());

            //Setup the Name, ToolTip, Help Description, and the Bitmap for this functoid
            SetName("IDS_ADVLOGICALGT_NAME");
            SetTooltip("IDS_ADVLOGICALGT_TOOLTIP");
            SetDescription("IDS_ADVLOGICALGT_DESCRIPTION");
            SetBitmap("IDB_ADVLOGICALGT");

            //Set the function name that is to be called when invoking this functoid.
            // To test the map in Visual Studio, this functoid does not need to be in the GAC.
            // If using this functoid in a deployed BizTalk app. then it must be in the GAC
            SetScriptBuffer(ScriptType.CSharp, this.GetCSharpBuffer());

            base.RequiredGlobalHelperFunctions = InlineGlobalHelperFunction.IsNumeric;
            base.Category = FunctoidCategory.Logical;
            base.OutputConnectionType = ConnectionType.FunctoidString | ConnectionType.Element | ConnectionType.FunctoidAssert | ConnectionType.FunctoidNilValue | ConnectionType.FunctoidKeyMatch | ConnectionType.FunctoidTableLooping | ConnectionType.FunctoidValueMapping | ConnectionType.FunctoidScripter | ConnectionType.FunctoidLogical;
            base.HasSideEffects = false;
            base.AddInputConnectionType(ConnectionType.AllExceptRecord);
            base.AddInputConnectionType(ConnectionType.AllExceptRecord);
        }

        private string GetCSharpBuffer()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("public bool LogicalGt(string val1, string val2)\n");
            builder.Append("{\n");
            builder.Append("\tbool ret = false;\n");
            builder.Append("\tdouble d1 = 0;\n");
            builder.Append("\tdouble d2 = 0;\n");
            builder.Append("\tif (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))\n");
            builder.Append("\t{\n");
            builder.Append("\t\tret = d1 > d2;\n");
            builder.Append("\t}\n");
            builder.Append("\telse\n");
            builder.Append("\t{\n");
            builder.Append("\t\tret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;\n");
            builder.Append("\t}\n");
            builder.Append("\treturn ret;\n");
            builder.Append("}\n");
            return builder.ToString();
        }
    }
}
