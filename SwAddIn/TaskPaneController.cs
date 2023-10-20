using System.ComponentModel;
using System.Runtime.InteropServices;
using Xarial.XCad.Base.Attributes;
using Xarial.XCad.SolidWorks;

namespace SwAddIn
{
    [ComVisible(true), Guid("7da599ee-7a53-4107-a563-8ee935fc8288")]
    [Title("KnightsPDM"), Description("A custom PDM solution for KXR")]
    public class TaskPaneController : SwAddInEx
    {
        public override void OnConnect()
        {
            CreateTaskPane<WpfUserControl>();
        }
    }
}