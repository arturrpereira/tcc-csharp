﻿using System;

namespace partidaService.model.entities
{
    public class Partida
    {
        public int id_partida { get; set; }
        public DateTime data { get; set; }
        public int timeVencedor { get; set; }
        public float valorApostado { get; set; }
    }
}