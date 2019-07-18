using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPDemo.Model
{
    /// <summary>
    /// 设备类型
    /// </summary>
    public class Device
    {
        private string _id;
        private string _name;
        private Point _position;
        /// <summary>
        /// 设备ID
        /// </summary>
        public string ID
        {
            get { return _id; }
            set
            {
                if(value != _id)
                {
                    _id = value;
                }
            }
        }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != _name)
                {
                    _name = value;
                }
            }
        }
        /// <summary>
        /// 设备位置
        /// </summary>
        public Point Position

        {
            get { return _position; }
            set
            {
                if (value != _position)
                {
                    _position = value;
                }
            }
        }
        /// <summary>
        /// 创建设备
        /// </summary>
        /// <param name="name"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static Device CreatDevice(string name, Point point)
        {
            Device newDevice = new Device();
            newDevice.ID = Guid.NewGuid().ToString();
            newDevice.Name = name;
            newDevice.Position = point;

            return newDevice;
        }
    }
}
