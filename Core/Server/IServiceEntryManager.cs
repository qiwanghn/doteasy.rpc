using System.Collections.Generic;
using Easy.Rpc.Core.Communally.Entitys;

namespace Easy.Rpc.Core.Server
{
    /// <summary>
    /// 抽象的服务条目管理者
    /// </summary>
    public interface IServiceEntryManager
    {
        /// <summary>
        /// 获取服务条目集合
        /// </summary>
        /// <returns>服务条目集合</returns>
        IEnumerable<ServiceEntity> GetEntries();
    }
}