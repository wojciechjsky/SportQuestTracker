﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using SportQuestTrackerUI.Contracts;
using SportQuestTrackerUI.Models;

namespace SportQuestTrackerUI.Service
{
    public class QuestRepository : BaseRepository<Quest>, IQuestRepository
    {
        private readonly IHttpClientFactory _client;
        private readonly ILocalStorageService _localStorage;
        public QuestRepository(IHttpClientFactory client,
            ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }
    }
}
