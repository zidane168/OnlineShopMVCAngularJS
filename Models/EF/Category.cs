namespace Models.EF
{
    using System;    
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;    

    [Table("Category")]
    public partial class Category       // use partial class for add add code to the class later 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Alias { get; set; }

        public int? ParentID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? IsOder { get; set; }

        public bool? Status { get; set; }
    }
}

// file1.cs
//namespace TestPartialType
//{
//    public partial class ClassPartialDemo
//    {
//        public string XTitle
//        {
//            set; get;
//        }

//        public int XIndex { set; get; }
//    }
//}


// file2.cs
//namespace TestPartialType
//{
//    public partial class ClassPartialDemo
//    {
//        public string Display()
//        {
//            return XIndex + ": " + XTitle;
//        }
//    }
//}

//
//ClassPartialDemo par = new ClassPartialDemo();
//par.XIndex = 88;
//par.XTitle = "Partial type";
//Console.WriteLine(par.XDisplay());