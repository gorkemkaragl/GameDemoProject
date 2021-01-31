﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemoProject
{
    interface IGamerManager
    {
        void Save(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
