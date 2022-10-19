using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //Product
        public static string ProductAdded => "The product has been added."; 
        public static string ProductDeleted => "The product has been deleted."; 
        public static string ProductUpdated => "The product has been updated.";
        public static string ProductListed => "The products are listed.";



        //Order
        public static string OrderAdded => "The order has been added.";
        public static string OrderDeleted => "The order has been deleted.";
        public static string OrderUpdated => "The order has been updated.";

        //Category
        public static string CategoryAdded => "The category has been added.";
        public static string CategoryDeleted => "The category has been deleted.";
        public static string CategoryUpdated => "The category has been updated.";

        public static string MaintenanceTime => "The system is currently under maintenance.";

    }
}
