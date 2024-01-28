namespace SimpleSession
{
    public static class SimpleSessionHandler
    {
        public static List<SimpleSession> ActiveSessions { get; } = new List<SimpleSession>();

        public static void AddSession(SimpleSession session)
        {
            if (ActiveSessions.Contains(session))
                return;

            ActiveSessions.Add(session);
        }

        public static void RemoveSession(string sessionId)
        {
            var foundSession = ActiveSessions.Find(s => s.SessionId == sessionId);
            if (foundSession == null)
                return;
            ActiveSessions.Remove(foundSession);
        }

        public static SimpleSession? GetSessionById(string sessionId)
        {
            return ActiveSessions.Find(s => s.SessionId == sessionId);
        }

        public static void Clear()
        {
            ActiveSessions.Clear();
        }
    }


}
