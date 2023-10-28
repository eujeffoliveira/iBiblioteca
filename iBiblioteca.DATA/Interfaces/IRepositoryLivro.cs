using iBiblioteca.DATA.Models;

namespace iBiblioteca.DATA.Interfaces
{
    // Interface que herda de IRepositoryModel e é específica para o modelo Tblivro.
    public interface IRepositoryLivro : IRepositoryModel<Tblivro>
    {
        // Esta interface não adiciona novos métodos em relação à IRepositoryModel,
        // mas é usada para definir operações específicas para o modelo Tblivro, se necessário.
    }
}