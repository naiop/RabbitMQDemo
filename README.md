# RabbitMQDemo
RabbitMQ消息队列测试


### —. RabbitMQ

RabbitMQ 是高级消息队列协议（AMQP）的开源消息代理软件。RabbitMQ 服务器是用 Erlang 语言编写的，消息系统允许软件、应用相互连接和扩展．这些应用可以相互链接起来组成一个更大的应用， 或者将用户设备和数据进行连接．消息系统通过将消息的发送和接收分离来实现应用程序的异 步和解偶． 或许你正在考虑进行数据投递，非阻塞操作或推送通知。或许你想要实现发布／订阅，异步处理， 或者工作队列。所有这些都可以通过消息实现。 RabbitMQ 是一个消息代理 - 一个消息系统的媒介。它可以为你的应用提供一个通用的消息发 送和接收平台，并且保证消息在传输过程中的安全。

### 二．安装RabbitMQ

RabbitMQ 需要安装 64 位支持的 Erlang for Windows 版本
所需框架与安装版本官网均可免费下载

<img  src="https://naiop.github.io/mimages/blog/RabbitMQ_img1.png"  />

1安装 otp_win64_24.0.exe (Erlang) 因为RabbitMQ 它依赖于Erlang,需要先安装Erlang

<img  src="https://naiop.github.io/mimages/blog/RabbitMQ_img2.png"   />

2.安装RabbitMQ Server

<img  src="https://naiop.github.io/mimages/blog/RabbitMQ_img3.png"  />
3.安装完成后 打开命令提示符 cd到  rabbitmq_server-3.8.19\sbin  目录下

输入命令：
rabbitmq-plugins enable rabbitmq_management

停止：net stop RabbitMQ
启动：net start RabbitMQ

在浏览器中输入地址查看：http://127.0.0.1:15672/

使用默认账号登录：guest/ guest

<img  src="https://naiop.github.io/mimages/blog/RabbitMQ_img4.png"   />

### 三．Demo测试

1.写个生产消息Demo
<img  src="https://naiop.github.io/mimages/blog/RabbitMQ_img5.png"   />
2.登录Rabbit服务可以看到生产的消息
<img  src="https://naiop.github.io/mimages/blog/RabbitMQ_img6.png"   />
3.再写个接受消息Demo
<img  src="https://naiop.github.io/mimages/blog/RabbitMQ_img7.png"   />
