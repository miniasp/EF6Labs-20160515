// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

namespace EFPOCOGen
{

    // vwDeptCourseCount
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.2.0")]
    public partial class VwDeptCourseCountConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<VwDeptCourseCount>
    {
        public VwDeptCourseCountConfiguration()
            : this("dbo")
        {
        }
 
        public VwDeptCourseCountConfiguration(string schema)
        {
            ToTable(schema + ".vwDeptCourseCount");
            HasKey(x => x.DepartmentId);

            Property(x => x.DepartmentId).HasColumnName(@"DepartmentID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CourseCount).HasColumnName(@"CourseCount").IsOptional().HasColumnType("int");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
