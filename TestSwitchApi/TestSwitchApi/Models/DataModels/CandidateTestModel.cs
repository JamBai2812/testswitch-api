﻿    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace TestSwitchApi.Models.DataModels
    {
        public class CandidateTestModel
        {
            /*[Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }*/
            [Key]
            public int CandidateId { get; set; }
            [Key]
            public int TestId { get; set; }
            public string TestResult { get; set; }
            public string TestAnswer { get; set; }
        }
    }
