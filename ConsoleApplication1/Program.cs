using ConsoleApplication1.model;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:9020/";
            //客户端采用json数据格式
            JsonServiceClient client1 = new JsonServiceClient(url);
            Console.WriteLine(url);
            //TicketRequest 为请求的方法
            //List<TicketResponse> responseSearch = client1.Get<List<TicketResponse>>(new TicketRequest() { TicketId = 1 });
            List<TicketResponse> responseSearch = client1.Get<List<TicketResponse>>(new TicketRequest() { TicketId = 3});
            Console.WriteLine(responseSearch.Count);

            Console.WriteLine("删除类型Any");
            bool responseDelete = client1.Post<bool>(new TicketDeleteRequest() { TicketId = 1 });
            Console.WriteLine(responseDelete);


            Console.WriteLine("删除类型Post");
            bool responseDelete2 = client1.Post<bool>(new TicketDeleteRequest() { TicketId = 1 });
            Console.WriteLine(responseDelete2);


            Console.WriteLine("测试请求Test");
            bool responseTest = client1.Post<bool>(new TestRequest() { Tname = "111" });
            Console.WriteLine(responseDelete2);

            Console.ReadLine();
        }
    }
}
