using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.Model
{
    /// <summary>
    /// 设备缓存：单例模式
    /// </summary>
    public class DeviceCache
    {
        private ObservableCollection<Device> _devices;

        private DeviceCache()
        {
            _devices = new ObservableCollection<Device>();
            _devices.CollectionChanged += _devices_CollectionChanged;
        }

        public Action<ObservableCollection<Device>> AddAction;
        public Action<ObservableCollection<Device>> RemoveAction;

        /// <summary>
        /// 数据变更事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _devices_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    ObservableCollection<Device> devicesChanged = new ObservableCollection<Device>();
                    foreach(var item in e.NewItems)
                    {
                        devicesChanged.Add(item as Device);
                    }
                    AddAction.Invoke(devicesChanged);
                    break;
                case NotifyCollectionChangedAction.Remove:
                    ObservableCollection<Device> devicesDeleted = new ObservableCollection<Device>();
                    foreach (var item in e.OldItems)
                    {
                        devicesDeleted.Add(item as Device);
                    }
                    RemoveAction.Invoke(devicesDeleted);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 设备存量
        /// </summary>
        public ObservableCollection<Device> Devices
        {
            get { return _devices; }
            set
            {
                if(value != _devices)
                {
                    _devices = value;
                }
            }
        }
        /// <summary>
        /// 查看Cache中的数据
        /// </summary>
        public void ShowCache()
        {
            int i = 0;
            Console.WriteLine("*********************************查寻Cache数据*******************************");
            foreach (Device device in _devices)
            {
                i++;
                Console.WriteLine("=======================Device【{0}】========================", i);
                Console.Write("ID:" + device.ID);
                Console.Write("Name:" + device.Name);
                Console.Write("Position:" + device.Position);
                Console.Write("\n");
            }
            Console.WriteLine("*****************************************************************************");
        }

        /// <summary>
        /// 单例模式
        /// </summary>
        private static DeviceCache _cacheInstance = null;
        private static Object _syncLock = new object();

        public static DeviceCache GetInstance()
        {
            if(_cacheInstance == null)
            {
                lock(_syncLock)
                {
                    if(_cacheInstance == null)
                    {
                        _cacheInstance = new DeviceCache();
                    }
                }
            }
            return _cacheInstance;
        }
    }
}
