#region Namespaces

using System.Collections.Generic;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

#endregion

namespace QApps
{
    public class AutoJoinViewModel : ViewModelBase
    {
        public Document Doc;
        public UIDocument UiDoc;

        #region Khai báo Binding Properties 

        public List<AutoJoinRules> AllRules { get; set; } 
            = new List<AutoJoinRules>();

        #endregion Khai báo Binding Properties 

        public AutoJoinViewModel(UIDocument uidoc)
        {
            Doc = uidoc.Document;
            UiDoc = uidoc;

            AllRules.Add(new AutoJoinRules());
        }
    }
}
