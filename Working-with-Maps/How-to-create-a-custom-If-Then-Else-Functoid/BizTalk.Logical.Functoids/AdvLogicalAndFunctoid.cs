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
    public class AdvLogicalAndFunctoid : BaseFunctoid
    {
        public AdvLogicalAndFunctoid()
        {
            //ID for this functoid
            this.ID = 10902;

            // resource assembly must be ProjectName.ResourceName if building with VS.Net
            this.SetupResourceAssembly("BizTalk.Logical.Functoids.LogicalResources", Assembly.GetExecutingAssembly());

            //Setup the Name, ToolTip, Help Description, and the Bitmap for this functoid
            SetName("IDS_ADVLOGICALAND_NAME");
            SetTooltip("IDS_ADVLOGICALAND_TOOLTIP");
            SetDescription("IDS_ADVLOGICALAND_DESCRIPTION");
            SetBitmap("IDB_ADVLOGICALAND");

            //Set the function name that is to be called when invoking this functoid.
            // To test the map in Visual Studio, this functoid does not need to be in the GAC.
            // If using this functoid in a deployed BizTalk app. then it must be in the GAC
            base.AddScriptTypeSupport(ScriptType.CSharp);

            base.RequiredGlobalHelperFunctions = InlineGlobalHelperFunction.ValToBool | InlineGlobalHelperFunction.IsNumeric;
            base.Category = FunctoidCategory.Logical;
            base.OutputConnectionType = ConnectionType.FunctoidString | ConnectionType.Element | ConnectionType.FunctoidAssert | ConnectionType.FunctoidNilValue | ConnectionType.FunctoidKeyMatch | ConnectionType.FunctoidTableLooping | ConnectionType.FunctoidValueMapping | ConnectionType.FunctoidScripter | ConnectionType.FunctoidLogical;
            base.AddScriptTypeSupport(ScriptType.CSharp);
            base.SetMinParams(2);
            base.SetMaxParams(100);
            base.HasSideEffects = false;
            for (int i = 0; i < 100; i++)
            {
                base.AddInputConnectionType(ConnectionType.AllExceptRecord);
            }
        }

        protected override string GetInlineScriptBuffer(ScriptType scriptType, int numParams, int functionNumber)
        {
            if (ScriptType.CSharp != scriptType)
            {
                return "";
            }
            StringBuilder builder = new StringBuilder();
            builder.Append(base.BuildDynamicScriptHeader("LogicalAnd", "bool", "string", numParams));
            builder.Append("{\n");
            if (numParams > 0)
            {
                bool flag = true;
                builder.Append("\treturn ");
                for (int i = 0; i < numParams; i++)
                {
                    if (flag)
                    {
                        flag = false;
                    }
                    else
                    {
                        builder.Append(" && ");
                    }
                    builder.Append("ValToBool(param");
                    builder.Append(i);
                    builder.Append(")");
                }
                builder.Append(";\n");
            }
            builder.Append("\treturn false;\n");
            builder.Append("}\n");
            return builder.ToString();
        }
    }
}
