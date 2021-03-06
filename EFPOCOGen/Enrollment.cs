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

    // Enrollment
    [System.CodeDom.Compiler.GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.19.2.0")]
    public partial class Enrollment
    {
        public int EnrollmentId { get; set; } // EnrollmentID (Primary key)
        public int CourseId { get; set; } // CourseID
        public int StudentId { get; set; } // StudentID
        public int? Grade { get; set; } // Grade

        // Foreign keys
        public virtual Course Course { get; set; } // FK_dbo.Enrollment_dbo.Course_CourseID
        public virtual Person Person { get; set; } // FK_dbo.Enrollment_dbo.Person_StudentID
        
        public Enrollment()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
