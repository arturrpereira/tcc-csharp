using partidaService.model.dao;
using partidaService.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.model.dao;

namespace partidaService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Services service = new Services();
            service.montagemDePartida();
            service.fechamentoPartida();
        }
    }
}
