using MVPDemo.Model;
using MVPDemo.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo
{
    class Demo
    {
        /// <summary>
        /// 以新增和删除设备为例，使用单例模式和MVP设计模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            //获取缓存
            DeviceCache cacheInstance = DeviceCache.GetInstance();
            //创建View实例
            DemoView view = new DemoView();
            //创建四个新设备
            Device device1 = Device.CreatDevice("device_1", new Point(0, 0));
            Device device2 = Device.CreatDevice("device_2", new Point(0, 1));
            Device device3 = Device.CreatDevice("device_3", new Point(1, 0));
            Device device4 = Device.CreatDevice("device_4", new Point(1, 1));

            //添加四个设备
            List<Device> newDevices = new List<Device>() { device1, device2, device3, device4 };
            foreach(Device newDevice in newDevices)
            {
                view.NewDeviceAdding(newDevice);
            }
            cacheInstance.ShowCache();

            //删除设备2
            view.DeviceRemoving(device2);
            cacheInstance.ShowCache();

            Console.ReadKey();
        }      
    }
}
