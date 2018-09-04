namespace unipaulistana.model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class NovaSenha
    {
        [Required(ErrorMessage="Entre com a senha anterior.")]
        [DataType(DataType.Password)]
        public string SenhaAnterior { get; set; }

        [Required(ErrorMessage="Entre com uma senha.")]
        [StringLength(10, ErrorMessage = "O tamanho da senha deve conter entre 5 e 10 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage="O campo confirmar senha é requerido.")]
        [StringLength(10, ErrorMessage = "O tamanho da senha deve conter entre 5 e 10 caracteres", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage="A senha informada não é igual a senha confirmada.")]
        public string ConfirmarSenha { get; set; }
    }
}
