using partidaService.model.dao;
using partidaService.model.dao.impl;
using partidaService.model.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using tcc_csharp.Data;
using tcc_csharp.model.dao.impl;

namespace partidaService
{
    public class Services
    {
        private readonly IFila _filaRep;
        private readonly IPartida _partidaRep;
        private readonly IPartidaUsuario _partidaUsuarioRep;
        private readonly IMovimentacoes _movimentacoesRep;
        private readonly IUsuario _usuarioRep;

        public Services()
        {
            this._filaRep = new FilaRepository(new Postgre());
            this._partidaRep = new PartidaRepository(new Postgre());
            this._partidaUsuarioRep = new PartidaUsuarioRepository(new Postgre());
            this._movimentacoesRep = new MovimentacoesRepository(new Postgre());
            this._usuarioRep = new UsuarioRepository(new Postgre());
        }

        public void montagemDePartida()
        {
            List<Fila> fila = _filaRep.findAll();

            List<Fila> tops = new List<Fila>();
            List<Fila> jungles = new List<Fila>();
            List<Fila> mids = new List<Fila>();
            List<Fila> atiradores = new List<Fila>();
            List<Fila> suportes = new List<Fila>();

            // Injetar nas fila
            foreach (Fila queue in fila)
            {
                if (queue.role == "Topo")
                {
                    tops.Add(queue);
                }
                if (queue.role == "Selva")
                {
                    jungles.Add(queue);
                }
                if (queue.role == "Meio")
                {
                    mids.Add(queue);
                }
                if (queue.role == "Atirador")
                {
                    atiradores.Add(queue);
                }
                if (queue.role == "Suporte")
                {
                    suportes.Add(queue);
                }
            }
            int quantidadeMinima = Math.Min(tops.Count, Math.Min(jungles.Count, Math.Min(mids.Count, Math.Min(atiradores.Count, suportes.Count))));
            int numeroDePartidas = (int)quantidadeMinima / 2;


            for (int i = 0; i < numeroDePartidas; i++)
            {
                PartidaUsuario partidaUsuario = new PartidaUsuario();
                List<Fila> blueTeam = new List<Fila>
                {
                    tops[i],
                    jungles[i],
                    mids[i],
                    atiradores[i],
                    suportes[i],
                };

                List<Fila> redTeam = new List<Fila>
                {
                    tops[i+1],
                    jungles[i+1],
                    mids[i+1],
                    atiradores[i+1],
                    suportes[i+1],
                };

                tops.RemoveAt(i);
                tops.RemoveAt(i);

                jungles.RemoveAt(i);
                jungles.RemoveAt(i);

                mids.RemoveAt(i);
                mids.RemoveAt(i);

                atiradores.RemoveAt(i);
                atiradores.RemoveAt(i);

                suportes.RemoveAt(i);
                suportes.RemoveAt(i);

                subirPartida(blueTeam, redTeam);
            }
        }

        public void fechamentoPartida()
        {
            List<Partida> partidasAbertas = new List<Partida>();
            foreach(Partida partidas in _partidaRep.findAll())
            {
                if(partidas.timeVencedor == 0)
                {
                    partidasAbertas.Add(partidas);
                }
            }

            foreach(Partida partidas in partidasAbertas)
            {
                List<PartidaUsuario> analisePartidas = _partidaUsuarioRep.findByPartida(partidas);
                int votosBlue = 0;
                int votosRed = 0;

                foreach(PartidaUsuario partidaUser in analisePartidas)
                {
                    if(partidaUser.votoUsuario == 1)
                    {
                        votosBlue += 1;
                    }
                    if(partidaUser.votoUsuario == 2)
                    {
                        votosRed += 1;
                    }

                }

                if (votosBlue >= 6)
                {
                    partidas.timeVencedor = 1;
                    _partidaRep.update(partidas);
                    movimentacoes(partidas, analisePartidas);
                }

                if (votosRed >= 6)
                {
                    partidas.timeVencedor = 2;
                    _partidaRep.update(partidas);
                    movimentacoes(partidas, analisePartidas);
                }
            }
        }

        private void movimentacoes(Partida partida, List<PartidaUsuario> partidaUser)
        {
            int idPartida = partida.id_partida;
            float valorAposta = partida.valorApostado;
            int timeVencedor = partida.timeVencedor;

            foreach(PartidaUsuario partUser in partidaUser)
            {
                Movimentacao movimentacao = new Movimentacao();
                movimentacao.valor = valorAposta;

                if(partUser.time == timeVencedor)
                {
                    Usuario usuario = new Usuario();
                    usuario = partUser.usuario;

                    movimentacao.tipooperacao = 1;
                    usuario.saldo = usuario.saldo + (valorAposta * 2);

                    movimentacao.usuario = partUser.usuario;
                    movimentacao.Partida = partida;
                    _usuarioRep.update(usuario);
                }

                if (partUser.time != timeVencedor)
                {
                    movimentacao.tipooperacao = 2;
                }
                movimentacao.usuario = partUser.usuario;
                movimentacao.Partida = partida;
                _movimentacoesRep.insert(movimentacao);
            }
        }

        private void subirPartida(List<Fila> blueTeam, List<Fila> redTeam)
        {
            float menorApostaBlue = blueTeam.Min(aposta => aposta.valorSugerido);
            float menorApostaRed = redTeam.Min(aposta => aposta.valorSugerido);
            float apostaReal = 0;

            if(menorApostaBlue < menorApostaRed)
            {
                apostaReal = menorApostaBlue;
            }
            else
            {
                apostaReal = menorApostaRed;
            }

            Partida partida = new Partida();
            partida.data = DateTime.Now;
            partida.timeVencedor = 0;
            partida.valorApostado = apostaReal;

            int idPartida = _partidaRep.insert(partida);

            foreach(Fila blue in blueTeam) 
            {
                PartidaUsuario partidaUsuario = new PartidaUsuario();
                partidaUsuario.time = 1;
                partidaUsuario.role = blue.role;
                partidaUsuario.votoUsuario = 0;
                partidaUsuario.usuario.id_usuario = blue.usuario.id_usuario;
                partidaUsuario.partida.id_partida = idPartida;

                Usuario usuario = new Usuario();
                usuario = _usuarioRep.findById(partidaUsuario.usuario.id_usuario);
                //usuario.saldo -= apostaReal;
                usuario.saldo = (usuario.saldo - apostaReal);

                _partidaUsuarioRep.insert(partidaUsuario);
                _filaRep.deleteById(partidaUsuario.usuario.id_usuario);
                _usuarioRep.update(usuario);
            }

            foreach(Fila red in redTeam) 
            {
                PartidaUsuario partidaUsuario = new PartidaUsuario();
                partidaUsuario.time = 2;
                partidaUsuario.role = red.role;
                partidaUsuario.votoUsuario = 0;
                partidaUsuario.usuario.id_usuario = red.usuario.id_usuario;
                partidaUsuario.partida.id_partida = idPartida;

                Usuario usuario = new Usuario();
                usuario = _usuarioRep.findById(partidaUsuario.usuario.id_usuario);
                usuario.saldo -= apostaReal;

                _partidaUsuarioRep.insert(partidaUsuario);
                _filaRep.deleteById(partidaUsuario.usuario.id_usuario);
                _usuarioRep.update(usuario);
            }
        }
    }
}
