using Model;
using ServiceStack;
using System.Collections.Generic;

namespace Interface
{
    public interface ITicketService
    {
        /// <summary>
        /// 方法请求模式和路由规则 后面再说
        /// 请求票据列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        List<TicketResponse> Get(TicketRequest request);
        /// <summary>
        /// 删除指定票据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool Any(TicketDeleteRequest deleteid);


        /// <summary>
        /// 删除指定票据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool Any(TestRequest test);
        /// <summary>
        /// 删除指定票据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //bool Post(TicketDeleteRequest deleteid);
    }
}
