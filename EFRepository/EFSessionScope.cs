using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighScore;

namespace EFRepository
{
    public class EFSessionScope : ISessionScope
    {
        public EFSessionScope()
        {
            gameRepo = new Lazy<IGameRepos>(() => new EFGameRepos(Ctx), false);

            scoreRepos = new Lazy<IScoreRepos>(() => new EFScoreRepso(Ctx), false);

            userRepos = new Lazy<IUserRepos>(() => new EFUserRepos(Ctx), false);
        }
        private Lazy<HighScoreDbContext> ctx = new Lazy<HighScoreDbContext>(() => new HighScoreDbContext(), false);

        public HighScoreDbContext Ctx => ctx.Value;

        private Lazy<IGameRepos> gameRepo;

        private Lazy<IScoreRepos> scoreRepos;

        private Lazy<IUserRepos> userRepos;

        public IGameRepos GameRepos => gameRepo.Value;

        public IScoreRepos ScoreRepos => scoreRepos.Value;

        public IUserRepos UserRepos => userRepos.Value;

        public void Save()
        {
            Ctx.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if(ctx.IsValueCreated)
                        Ctx.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~EFSessionScope() {
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
