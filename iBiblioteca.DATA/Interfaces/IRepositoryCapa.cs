using iBiblioteca.DATA.Models;

namespace iBiblioteca.DATA.Interfaces
{
    // Interface que herda de IRepositoryModel e é específica para o modelo TbcapaLivro.
    public interface IRepositoryCapa : IRepositoryModel<TbcapaLivro>
    {
        // Esta interface não adiciona novos métodos em relação à IRepositoryModel,
        // mas é usada para definir operações específicas para o modelo TbcapaLivro, se necessário.
    }
}