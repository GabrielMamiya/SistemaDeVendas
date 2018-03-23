using System;

namespace Testes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CamadaDados.dCategoria newCategoria = new CamadaDados.dCategoria(2, "Mylena Tamura", "A Gostosa", "Vadia");


            try{
				//CamadaDados.dCategoria.Inserir(newCategoria);
                //CamadaDados.dCategoria.Editar(newCategoria);
                //CamadaDados.dCategoria.Excluir(newCategoria);
                CamadaDados.dCategoria.Mostrar();
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }

        }
    }
}
