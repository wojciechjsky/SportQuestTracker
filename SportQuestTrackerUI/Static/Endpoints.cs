using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportQuestTrackerUI.Static
{
    public static class Endpoints
    {
        public static string BaseUrl = "https://localhost:44382/";
        public static string UsersEndpoint = $"{BaseUrl}api/users/";
        public static string GadgetsEndpoint = $"{BaseUrl}api/gadget/";
        public static string RegisterEndpoint = $"{BaseUrl}api/users/register/";
        public static string LoginEndpoint = $"{BaseUrl}api/users/login/";
        public static string QuestEndpoint = $"{BaseUrl}api/quest/";
    }
}
