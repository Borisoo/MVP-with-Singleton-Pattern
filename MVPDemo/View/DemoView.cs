using MVPDemo.IPresenter;
using MVPDemo.IView;
using MVPDemo.Model;
using MVPDemo.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.View
{
    public class DemoView : IDemoView
    {
        private IDemoPresenter _presenter;

        public DemoView()
        {
            _presenter = new DemoPresenter(this);
        }
        void IDemoView.AddDeviceView(Device device)
        {
            Console.WriteLine("绘制设备：" + device.Name + "-" + device.ID);
        }

        void IDemoView.RemoveDeviceView(Device device)
        {
            Console.WriteLine("删除设备：" + device.Name + "-" + device.ID);
        }
        /// <summary>
        /// 开始添加设备，调用Presenter的设备添加处理方法
        /// </summary>
        /// <param name="device"></param>
        public void NewDeviceAdding(Device device)
        {
            Console.WriteLine("开始添加设备：" + device.Name + "-" + device.ID);
            _presenter.AddDeviceToCache(device);
        }
        /// <summary>
        /// 开始删除设备，调用Presenter的设备删除处理方法
        /// </summary>
        /// <param name="device"></param>
        public void DeviceRemoving(Device device)
        {
            Console.WriteLine("开始删除设备：" + device.Name + "-" + device.ID);
            _presenter.DeleteDeviceFromCache(device.ID);
        }
    }
}
