using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Common;

namespace Server 
{
    public class Host<TEntity> : IDisposable where TEntity : IControllerFactory, new()
    {
        ServiceHost host = new ServiceHost(typeof(HighScoreService<TEntity>));

        public void StartServer()
        {
            Uri baseAdress = new Uri("net.tcp://localhost:8009/HighScore");
            NetTcpBinding binding = new NetTcpBinding();
            host.AddServiceEndpoint(typeof(IService), binding, baseAdress);
            host.Open();

            Console.WriteLine("Server started");
            Console.ReadKey();
            host.Close();
        }
        
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    (host as IDisposable).Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Host() {
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
