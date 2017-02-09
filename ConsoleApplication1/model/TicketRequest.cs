using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    /// <summary>
    /// 创建票据 请求实体
    /// IReturn<TicketResponse> 指该方法返回的数据实体
    /// </summary>
    public class TicketRequest
    {
        public int TicketId { get; set; }
        public int TableNumber { get; set; }
        public int ServerId { get; set; }
    }
    public class TicketDeleteRequest
    {
        public int TicketId { get; set; }
    }

    /// <summary>
    /// 测试请求
    /// </summary>
    public class TestRequest
    {
        public string Tname { get; set; }
    }
}
