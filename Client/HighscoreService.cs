using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Client
{
    public class HighscoreService : IService, IDisposable
    {
        private ChannelFactory<IService> factory;

        public HighscoreService()
        {
            Uri baseAdress = new Uri("net.tcp://localhost:8009/HighScore");
            EndpointAddress adress = new EndpointAddress(baseAdress);
            NetTcpBinding binding = new NetTcpBinding();
            factory = new ChannelFactory<IService>(binding, adress);
        }

        private TEntity DoStuff<TEntity>(Func<IService, TEntity> func)
        {
            IService service = factory.CreateChannel();
            TEntity entity = func(service);
            (service as IChannel).Close();
            return entity;
        }

        public Game CreateGame(string name)
        {
            return DoStuff(s => s.CreateGame(name));
        }

        public Score CreateScore(int points, Game game, User user)
        {
            return DoStuff(s => s.CreateScore(points, game, user));
        }

        public User CreateUser(string name)
        {
            return DoStuff(u => u.CreateUser(name));
        }

        public IEnumerable<Game> GetGames()
        {
            return DoStuff(g => g.GetGames());
        }

        public IEnumerable<Score> GetScoresPerGame(Game game)
        {
            return DoStuff(s => s.GetScoresPerGame(game));
        }

        public IEnumerable<Score> GetScoresPerUser(User user)
        {
            return DoStuff(s => s.GetScoresPerUser(user));
        }

        public IEnumerable<TotalScore> GetTotalScores()
        {
            return DoStuff(s => s.GetTotalScores());
        }

        public IEnumerable<User> GetUsers()
        {
            return DoStuff(s => s.GetUsers());
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    (factory as IDisposable).Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~HighscoreService() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
