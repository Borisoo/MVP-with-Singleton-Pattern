using MVPDemo.IModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.Model
{
    public class CacheOperation : ICacheOperation
    {
        private DeviceCache _cache;

        public CacheOperation()
        {
            _cache = DeviceCache.GetInstance();
        }
        /// <summary>
        /// 新增设备
        /// </summary>
        /// <param name="devices"></param>
        void ICacheOperation.AddDevice(List<Device> devices)
        {
            foreach(Device device in devices)
            {
                _cache.Devices.Add(device);
            }
            
        }
        /// <summary>
        /// 删除设备
        /// </summary>
        /// <param name="deviceIds"></param>
        void ICacheOperation.DeleteDevice(List<string> deviceIds)
        {
            foreach(string deviceId in deviceIds)
            {
                _cache.Devices.Remove(_cache.Devices.First(P => P.ID == deviceId));
            }
        }
    }
}
