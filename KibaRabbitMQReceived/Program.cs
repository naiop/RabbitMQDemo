using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibaRabbitMQReceived
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.UserName = "guest";
            factory.Password = "guest";

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare("TestQueue", false, false, false, null);

                    /* 这里定义了一个消费者，用于消费服务器接受的消息        
                     * 这里，其实就是定义一个EventingBasicConsumer类型的对象，然后该对象有个Received事件，该事件会在服务接收到数据时触发。
                     */ 
                    var consumer = new EventingBasicConsumer(channel);//消费者 
                    channel.BasicConsume("TestQueue", true, consumer);//消费消息 autoAck参数为消费后是否删除
                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine("Received： {0}", message);
                    };
                    Console.ReadLine();
                }
            }
        }
    }
}
