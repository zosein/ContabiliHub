namespace ContabiliHub.Application.DTOs
{
    public class UsuarioRegisterDto
    {
        public string NomeCompleto { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }
}