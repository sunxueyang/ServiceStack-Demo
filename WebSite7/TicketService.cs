using Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service
{
    public class TicketService : ServiceStack.Service, ITicketService
    {
        /// <summary>
        /// 方法请求模式和路由规则 后面再说
        /// 请求票据列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public List<TicketResponse> Get(TicketRequest request)
        {
            List<TicketResponse> result = new List<TicketResponse>();
            List<OrderResponse> orderlist = new List<OrderResponse>();
            orderlist.Add(new OrderResponse() { OrderId = 1 });
            result.Add(new TicketResponse()
            {
                Orders = orderlist,
                ServerId = 1,
                TableNumber = 1,
                TicketId = 1,
                Timestamp = DateTime.Now
            });
            result.Add(new TicketResponse()
            {
                Orders = orderlist,
                ServerId = 2,
                TableNumber = 2,
                TicketId = 2,
                Timestamp = DateTime.Now
            });

            if (request.TicketId > 5)
            {
                for (int i = 3; i < 6; i++)
                {
                    result.Add(new TicketResponse()
                    {
                        Orders = orderlist,
                        ServerId = i,
                        TableNumber = i,
                        TicketId = i,
                        Timestamp = DateTime.Now
                    });

                }
            }

            return result;
        }
        /// <summary>
        /// 删除指定票据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public bool Any(TicketDeleteRequest deleteid)
        {
            return false;
        }



        public bool Any(TestRequest test)
        {
            if (test.Tname?.Length > 0)
            {
                return true;
            }
            return false;
        }
        //public bool Post(TicketDeleteRequest deleteid)
        //{
        //    return true;
        //}

        //public bool Update(TicketDeleteRequest deleteid)
        //{
        //    return true;
        //}


    }
}