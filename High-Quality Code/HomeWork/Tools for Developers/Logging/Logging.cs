namespace Logging
{
    using log4net;
    using log4net.Config;

    public class Logging
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logging));

        /// <summary>
        /// Main Program Class
        /// </summary>
        /// <param name="args">Arguments area.</param>
        public static void Main(string[] args)
        {
            BasicConfigurator.Configure();

           
            log.Info("Entering application.");

            log.Debug("Debug message!");
            
            log.Error("Error message!");

            log.Info("Exiting application.");
        }
    }
}