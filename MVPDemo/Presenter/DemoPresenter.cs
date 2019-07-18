using MVPDemo.IModel;
using MVPDemo.IPresenter;
using MVPDemo.IView;
using MVPDemo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.Presenter
{
    public class DemoPresenter : IDemoPresenter
    {
        private IDemoView _view;

        private ICacheOperation _operation;

        public DemoPresenter(IDemoView view)
        {
            _view = view;
            _operation = new CacheOperation();
            DeviceCache cacheInstance = DeviceCache.GetInstance();
            cacheInstance.AddAction += AddDeviceToView;
            cacheInstance.RemoveAction += RemoveDeviceFromView;
        }
        
        void IDemoPresenter.AddDeviceToCache(Device device)
        {
            _operation.AddDevice(new List<Device>() { device });
        }

        void IDemoPresenter.DeleteDeviceFromCache(string deviceId)
        {
            _operation.DeleteDevice(new List<string>() { deviceId });
        }
        /// <summary>
        /// 添加设备到View，回调View的添加方法
        /// </summary>
        /// <param name="devices"></param>
        private void AddDeviceToView(ObservableCollection<Device> devices)
        {
            foreach(Device device in devices)
            {
                _view.AddDeviceView(device);
            }
        }
        /// <summary>
        /// 从View移除设备，回调View的移除方法
        /// </summary>
        /// <param name="devices"></param>
        private void RemoveDeviceFromView(ObservableCollection<Device> devices)
        {
            foreach (Device device in devices)
            {
                _view.RemoveDeviceView(device);
            }
        }
    }
}
