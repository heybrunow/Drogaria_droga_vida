//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projeto_estoque_drogavida
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using PagedList;
    using projeto_estoque_drogavida.Utils;

    public partial class produto
    {
        [Key]
        [Display(Name = "Id")]
        public int Id_produto { get; set; }
        [Required]
        [Display(Name = "Produto")]
        public string nome { get; set; }
        [Required]
        [Display(Name = "Cod. de barras")]
        public string cod_barra { get; set; }
        [Required]
        [Display(Name = "Descri��o")]
        public string descricao { get; set; }
        [NotMapped]
        public String descricaoResumida { get { return descricao.ToString().SubStringTo(10); } }
        [Display(Name = "Validade")]
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inv�lido")]
        public Nullable<System.DateTime> validade { get; set; }
        [Required]
        [Display(Name = "Marca")]
        public string marca { get; set; }
        [Required]
        [Display(Name = "Disponibilidade")]
        public Nullable<bool> status_produto { get; set; }
        [Required]
        [Display(Name = "Qtd")]
        public Nullable<int> qda_estoque { get; set; }
        [DataType(DataType.Currency)]
        [Required]
        [Display(Name = "Valor")]
        public Nullable<double> valor { get; set; }
        [Required]
        [Display(Name = "Unidade de medida")]
        public string unidade_de_medida { get; set; }
        [Required]
        [Display(Name = "Dosagem")]
        public string dosagem { get; set; }
    }

}
