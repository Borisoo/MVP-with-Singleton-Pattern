using MVPDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.IView
{
    public interface IDemoView
    {
        /// <summary>
        /// 往View上绘制设备
        /// </summary>
        /// <param name="device"></param>
        void AddDeviceView(Device device);
        /// <summary>
        /// 从View删除设备
        /// </summary>
        /// <param name="device"></param>
        void RemoveDeviceView(Device device);
    }
}
