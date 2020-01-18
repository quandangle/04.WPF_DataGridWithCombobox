#region Namespaces

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Application = Autodesk.Revit.ApplicationServices.Application;

#endregion

namespace QApps
{
    [Transaction(TransactionMode.Manual)]
    public class JoinElementsCmd : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData,
            ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            using (TransactionGroup transGr = new TransactionGroup(doc))
            {
                transGr.Start("Auto Join");

                AutoJoinViewModel viewModel = new AutoJoinViewModel(uidoc);
                AutoJoinWindow window = new AutoJoinWindow(viewModel);
                if (window.ShowDialog() == false) return Result.Cancelled;
              
                transGr.Commit();
            }

            return Result.Succeeded;
        }
    }
}
