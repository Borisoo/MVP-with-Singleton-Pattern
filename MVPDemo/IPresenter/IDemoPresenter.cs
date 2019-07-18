using MVPDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.IPresenter
{
    public interface IDemoPresenter
    {
        /// <summary>
        /// 向Cache中新增单个设备
        /// </summary>
        /// <param name="device"></param>
        void AddDeviceToCache(Device device);
        /// <summary>
        /// 从Cache中删除单个设备
        /// </summary>
        /// <param name="deviceId"></param>
        void DeleteDeviceFromCache(string deviceId);
    }
}
