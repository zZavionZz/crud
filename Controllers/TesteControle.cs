using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
namespace CRUD.Controllers
{
    

    public class Home : Controller
    {
        string conexao = @"Data Source = teste.db";

        IActionResult Index()
        {
            return View();
        }
        IActionResult Crud()
        {
            return View();
        }

        [HttpGet]
        public string login(string usuario, string senha)
        {
            using var cone = new SqliteConnection(conexao);
            cone.Open();

            string sqlLogin= @"
            select * from usuario
            where usuarios = @pusuarios and senha = @psenha
            ";

            using var cmdGrava = new SqliteCommand(sqlLogin, cone);

            cmdGrava.Parameters.AddWithValue("@pusuarios", usuario);
            cmdGrava.Parameters.AddWithValue("@psenha", senha);

            using var confere = cmdGrava.ExecuteReader();

            if (confere.Read())
            {
                return confere["nome"].ToString();
            }
            return "Erro";
            
        }

    }
}