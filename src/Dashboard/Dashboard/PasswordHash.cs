namespace Dashboard
{
    public static class PasswordHash
    {
        public static string HashPassword(string password)
        {
            // O número 12 é o custo computacional
            // mostra o temanho do hash
            return BCrypt.Net.BCrypt.HashPassword(password, 12);
        }

        public static bool VerifyPassword(string password, string hashPassword)
        {
            // Verifica se a senha digitada pelo usuário corresponde ao hash armazenado no banco de dados.
            // O método BCrypt.Net.Verify faz a comparação internamente
            return BCrypt.Net.BCrypt.Verify(password, hashPassword);
        }
    }

}
