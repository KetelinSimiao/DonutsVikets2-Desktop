namespace DonutsVikets.DTO
{
    public abstract class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public int CPF { get; set; }
      
    }
}

      

    
