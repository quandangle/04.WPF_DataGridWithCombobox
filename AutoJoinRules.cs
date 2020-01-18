using System.Collections.Generic;

namespace QApps
{
    public class AutoJoinRules : ViewModelBase
    {
        private string _priorityCategory;
        private string _joinWithCategory;

        public AutoJoinRules(string x = null)
        {
            AllCategoryPriority = AllJoinCategory.AllCategoryPriority;
            AllCutCategory = AllJoinCategory.AllCutCategory;
            PriorityCategory = AllCategoryPriority[0];
            JoinWithCategory = AllCutCategory[1];
        }
        public AutoJoinRules(AutoJoinRules rule)
        {
            AllCategoryPriority = AllJoinCategory.AllCategoryPriority;
            AllCutCategory = AllJoinCategory.AllCutCategory;
            PriorityCategory = rule.PriorityCategory;
            JoinWithCategory = rule.JoinWithCategory;
            IsReverse = rule.IsReverse;
        }

        public AutoJoinRules(string priorityCategory,string joinWithCategory)
        {
            AllCategoryPriority = AllJoinCategory.AllCategoryPriority;
            AllCutCategory = AllJoinCategory.AllCutCategory;
            PriorityCategory = priorityCategory;
            JoinWithCategory = joinWithCategory;
        }

        public string PriorityCategory
        {
            get => _priorityCategory;
            set
            {
                _priorityCategory = value;
                ConvertCategoryName();
                OnPropertyChanged();
            }
        }

        public string JoinWithCategory
        {
            get => _joinWithCategory;
            set
            {
                _joinWithCategory = value;
                ConvertCategoryName();
                OnPropertyChanged();
            }
        }

        public bool IsReverse
        {
            get => _isReverse;
            set
            {
                _isReverse = value;
                OnPropertyChanged();
            }
        }

        public List<string> AllCategoryPriority { get; set; }
        public List<string> AllCutCategory { get; set; }
        public string PriorityCategoryName;
        public string JoinWithCategoryName;

        private bool _isReverse;

        private void ConvertCategoryName()
        {
            switch (PriorityCategory)
            {
                case AllJoinCategory.Beam:
                    PriorityCategoryName = AllJoinCategory.BeamCategory;
                    break;
                case AllJoinCategory.Column:
                    PriorityCategoryName = AllJoinCategory.ColumnCategory;
                    break;
                case AllJoinCategory.Floor:
                    PriorityCategoryName = AllJoinCategory.FloorCategory;
                    break;
                case AllJoinCategory.Wall:
                    PriorityCategoryName = AllJoinCategory.WallCategory;
                    break;
                case AllJoinCategory.Foundation:
                    PriorityCategoryName = AllJoinCategory.FoundationCategory;
                    break;
                case AllJoinCategory.GenericModel:
                    PriorityCategoryName = AllJoinCategory.GenericModelCategory;
                    break;
                case AllJoinCategory.Ceiling:
                    PriorityCategoryName = AllJoinCategory.CeilingCategory;
                    break;
                case AllJoinCategory.Roof:
                    PriorityCategoryName = AllJoinCategory.RoofCategory;
                    break;
            }

            switch (JoinWithCategory)
            {
                case AllJoinCategory.Beam:
                    JoinWithCategoryName = AllJoinCategory.BeamCategory;
                    break;
                case AllJoinCategory.Column:
                    JoinWithCategoryName = AllJoinCategory.ColumnCategory;
                    break;
                case AllJoinCategory.Floor:
                    JoinWithCategoryName = AllJoinCategory.FloorCategory;
                    break;
                case AllJoinCategory.Wall:
                    JoinWithCategoryName = AllJoinCategory.WallCategory;
                    break;
                case AllJoinCategory.Foundation:
                    JoinWithCategoryName = AllJoinCategory.FoundationCategory;
                    break;
                case AllJoinCategory.GenericModel:
                    JoinWithCategoryName = AllJoinCategory.GenericModelCategory;
                    break;
                case AllJoinCategory.Ceiling:
                    JoinWithCategoryName = AllJoinCategory.CeilingCategory;
                    break;
                case AllJoinCategory.Roof:
                    JoinWithCategoryName = AllJoinCategory.RoofCategory;
                    break;
                case AllJoinCategory.All:
                    JoinWithCategoryName = AllJoinCategory.All;
                    break;
            }
        }
    }
}
