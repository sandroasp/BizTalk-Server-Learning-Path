using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.BizTalk.BaseFunctoids;
using System.Reflection;

namespace BizTalk.CustomAdvanced.Functoids
{
    [Serializable]
    public class IfThenElse : BaseFunctoid
    {
        public IfThenElse()
            : base()
        {
            //ID for this functoid
            this.ID = 10900;

            // resource assembly must be ProjectName.ResourceName if building with VS.Net
            SetupResourceAssembly("BizTalk.Logical.Functoids.LogicalResources", Assembly.GetExecutingAssembly());

            //Setup the Name, ToolTip, Help Description, and the Bitmap for this functoid
            SetName("IDS_IFELSEFUNCTOID_NAME");
            SetTooltip("IDS_IFELSEFUNCTOID_TOOLTIP");
            SetDescription("IDS_IFELSEFUNCTOID_DESCRIPTION");
            SetBitmap("IDS_IFELSEFUNCTOID_BITMAP");

            //category for this functoid. This functoid goes under the String Functoid Tab in the
            this.Category = FunctoidCategory.String;

            // Set the limits for the number of input parameters. This example: 1 parameter
            this.SetMinParams(3);
            this.SetMaxParams(3);

            // Add one line of code as set out below for each input param. For multiple input params, each line would be identical.
            this.AddInputConnectionType(ConnectionType.AllExceptRecord); //first input
            this.AddInputConnectionType(ConnectionType.AllExceptRecord); //Second input
            this.AddInputConnectionType(ConnectionType.AllExceptRecord); //Third input

            // The functoid output can go to any node type.
            this.OutputConnectionType = ConnectionType.AllExceptRecord;

            // Set the function name that is to be called when invoking this functoid.
            // To test the map in Visual Studio, this functoid does not need to be in the GAC.
            // If using this functoid in a deployed BizTalk app. then it must be in the GAC
            //SetExternalFunctionName(GetType().Assembly.FullName, GetType().FullName, "IfThenElseOperation");

            SetScriptBuffer(ScriptType.CSharp, this.GetCSharpBuffer());
            HasSideEffects = false;
        }

        private string GetCSharpBuffer()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("public string IfThenElseOperation(string condition, string trueValue, string falseValue)\n");
            builder.Append("{\n");
            builder.Append("\tif (System.Convert.ToBoolean(condition))\n");
            builder.Append("\t\treturn trueValue;\n");
            builder.Append("\treturn falseValue;\n");
            builder.Append("}\n");
            return builder.ToString();
        }

        public string IfThenElseOperation(string condition, string trueValue, string falseValue)
        {
            if (System.Convert.ToBoolean(condition))
                return trueValue;
            return falseValue;
        }
    }
}
