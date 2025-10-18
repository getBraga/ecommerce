using eCommerce.Models;

public class Usuario
{
    public int Id { get; private set; }
    public string Nome { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string? Sexo { get; private set; }
    public string RG { get; private set; } = null!;
    public string CPF { get; private set; } = null!;
    public string? NomeMae { get; private set; }
    public string? SituacaoCadastro { get; private set; }
    public DateTimeOffset DataCadastro { get; private set; } = DateTimeOffset.Now;
    public DateTimeOffset? DataAtualizacao { get; private set; }
    public Contato? ContatoUsuario { get; private set; }
    public ICollection<EnderecoEntrega>? EnderecosEntrega { get; private set; }
    public ICollection<Departamento>? Departamentos { get; private set; }

    protected Usuario() { }

    public static Usuario CriarUsuario(string nome, string email, string sexo, string rg, string cpf, string nomeMae, string situacaoCadastro, Contato? contatoUsuario, ICollection<EnderecoEntrega>? enderecoEntrega, ICollection<Departamento>? departamento)
    {
        var usuario = new Usuario();
        usuario.InicializarUsuario(nome, email, sexo, rg, cpf, nomeMae, situacaoCadastro, contatoUsuario, enderecoEntrega, departamento);
        return usuario;
    }

    public static Usuario AtualizarUsuario(int id, string nome, string email, string sexo, string rg, string cpf, string nomeMae, string situacaoCadastro, Contato? contatoUsuario, ICollection<EnderecoEntrega>? enderecoEntrega, ICollection<Departamento>? departamento)
    {
        var usuario = new Usuario();
        if(id < 0) throw new ArgumentException("Id inválido", nameof(id));
        usuario.UpdateUsuario(nome, email, sexo, rg, cpf, nomeMae, situacaoCadastro, contatoUsuario, enderecoEntrega, departamento);
        return usuario;
    }
    private void InicializarUsuario(string nome, string email, string sexo, string rg, string cpf, string nomeMae, string situacaoCadastro, Contato? contatoUsuario, ICollection<EnderecoEntrega>? enderecoEntrega, ICollection<Departamento>? departamento)
    {
        SetContatoUsuario(contatoUsuario);
        SetEnderecosEntrega(enderecoEntrega);
        SetDepartamentos(departamento);
        SetNome(nome);
        SetEmail(email);
        SetSexo(sexo);
        SetRG(rg);
        SetCPF(cpf);
        SetNomeMae(nomeMae);
        SetSituacaoCadastro(situacaoCadastro);
    }

    private void UpdateUsuario(string nome, string email, string sexo, string rg, string cpf, string nomeMae, string situacaoCadastro, Contato? contatoUsuario, ICollection<EnderecoEntrega>? enderecoEntrega, ICollection<Departamento>? departamento)
    {
        SetContatoUsuario(contatoUsuario);
        SetEnderecosEntrega(enderecoEntrega);
        SetDepartamentos(departamento);
        SetNome(nome);
        SetEmail(email);
        SetSexo(sexo);
        SetRG(rg);
        SetCPF(cpf);
        SetNomeMae(nomeMae);
        SetSituacaoCadastro(situacaoCadastro);
        DataAtualizacao = DateTimeOffset.Now;
    }

   
    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome)) throw new ArgumentException("Nome do usuário não pode ser vazio ou nulo.", nameof(nome));
        Nome = nome;
    }

    public void SetEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("Email do usuário não pode ser vazio ou nulo.", nameof(email));
        Email = email;
    }

    public void SetSexo(string? sexo) => Sexo = sexo;

    public void SetRG(string rg)
    {
        if (string.IsNullOrWhiteSpace(rg)) throw new ArgumentException("RG do usuário não pode ser vazio ou nulo.", nameof(rg));
        RG = rg;
    }

    public void SetCPF(string cpf)
    {
        if (string.IsNullOrWhiteSpace(cpf)) throw new ArgumentException("CPF do usuário não pode ser vazio ou nulo.", nameof(cpf));
        CPF = cpf;
    }

    public void SetNomeMae(string? nomeMae) => NomeMae = nomeMae;
    public void SetSituacaoCadastro(string? situacaoCadastro) => SituacaoCadastro = situacaoCadastro;
    public void SetContatoUsuario(Contato? contatoUsuario) => ContatoUsuario = contatoUsuario;
    public void SetEnderecosEntrega(ICollection<EnderecoEntrega>? enderecosEntrega) => EnderecosEntrega = enderecosEntrega;
    public void SetDepartamentos(ICollection<Departamento>? departamentos) => Departamentos = departamentos;
}
