using System;
using Rebus.MsgPack;
using Rebus.Serialization;

namespace Rebus.Config
{
    /// <summary>
    /// Configuration extensions for the Jil serializer
    /// </summary>
    public static class MsgPackConfigurationExtensions
    {
        /// <summary>
        /// Configures Rebus to use the simple and really fast MsgPack serializer
        /// </summary>
        public static void UseMsgPack(this StandardConfigurer<ISerializer> configurer)
        {
            if (configurer == null) throw new ArgumentNullException(nameof(configurer));
            configurer.Register(c => new MsgPackSerializer());
        }
    }
}