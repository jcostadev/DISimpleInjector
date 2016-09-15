using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;

namespace DISimpleInjector {
    class Program {
        static void Main(string[] args) {

            //creatring a simple injector container
            var container = new Container();

            //to make it a singleton we just need to write LifeStyle.Singleton and pass it to the registering type
            var lifestyle = Lifestyle.Singleton;

            //container.Register is used here to register the service ICart and its implementation DataAccessLayer
            container.Register<ICart, DataAccessLayer>(lifestyle);

            //get the instance
            var BL = container.GetInstance<BusinessLayer>();

            //calling the method
            BL.InsertToCart();

            Console.ReadLine();

            /*
            container.Register<IClientService, ClientService>();
            container.Register<IClientRepository, ClienteRepository>();

            //injeção de dependência
            Cliente Controller
            ClienteController(IClientService clientService)
            {
              _clientService = clientService;
            }

            //Dentro de ClienteController class posso criar o metodo

            public void Insert(dada dad)
            {
                 //através do container.Register e da injeção de dependência definida no construtor
                 //toda vez que esse metodo for chamado, a implementação dele dentro de ClientService vai ser chamada
                 //ClienteService Implementa IClientService

                _clientService.add(dad);
            }
            */
        }
    }
}
