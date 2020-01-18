#region Namespaces

using System.Collections.Generic;

#endregion

namespace QApps
{
    public static class AllJoinCategory
    {
        public static List<string> AllCategoryPriority = new List<string>()
        {
            "Beam",
            "Column",
            "Floor",
            "Wall",
            "Foundation",
            "Roof",
            "Ceiling",
            "Generic Model"
        };
        public static List<string> AllCutCategory = new List<string>()
        {
            "Beam",
            "Column",
            "Floor",
            "Wall",
            "Foundation",
            "Roof",
            "Ceiling",
            "Generic Model",
            "<All>"
        };

        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string BeamCategory = "Framing";
        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string ColumnCategory = "Columns";
        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string FloorCategory = "Floors";
        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string WallCategory = "Walls";
        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string FoundationCategory = "Foundations";
        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string GenericModelCategory = "Generic Models";
        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string CeilingCategory = "Ceilings";
        /// <summary>
        /// Tên Category của đối tượng
        /// </summary>
        public const string RoofCategory = "Roofs";
        
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string Beam = "Beam";
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string Column = "Column";
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string Floor = "Floor";
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string Wall = "Wall";
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string Foundation = "Foundation";
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string GenericModel = "Generic Model";
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string Ceiling = "Ceiling";
        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string Roof = "Roof";

        /// <summary>
        /// Tên xuất hiện ở Data grid
        /// </summary>
        public const string All = "<All>";
    }
}