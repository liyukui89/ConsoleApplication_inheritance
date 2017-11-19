using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_inheritance
{
    class star
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
        public void Introduce()
        {
            Console.WriteLine("我的名字叫： " + this.Name + "我的年龄是：" + this.Age);
        }
        
    }
    class singer : star
    {
        public string Song
        {
            get;
            set;
        }
        public new void Introduce()
        {
            Console.WriteLine( "我de的名字叫： " + this.Name + "我的年龄是：" + this.Age + "我的代表作是：" + this.Song);
        }
        static void Main(string[] args)
        {
            singer meng = new singer();
            meng.Name = "梦庭伟";
            meng.Age = 30;
            meng.Song = "谁的眼泪在飞";
            meng.Introduce();
            Console.ReadLine();   
        }
    }
    
}
