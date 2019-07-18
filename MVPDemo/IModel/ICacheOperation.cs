using MVPDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.IModel
{
    public interface ICacheOperation
    {
        /// <summary>
        /// 添加单个设备
        /// </summary>
        /// <param name="devices"></param>
        void AddDevice(List<Device> devices);

        /// <summary>
        /// 删除单个设备
        /// </summary>
        /// <param name="deviceIds"></param>
        void DeleteDevice(List<string> deviceIds);
    }
}
