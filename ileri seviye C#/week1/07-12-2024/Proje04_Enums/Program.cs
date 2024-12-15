/*
OrderStatus;
   1-Sipariş alındı,
   2-Kargo hazırlanıyor,
   3-Kargoya verildi,
   4-Teslim edildi.
*/

//Yeni Sipariş
// int orderStatus=1;

//Kargo hazırlanıyor
// orderStatus=2;

//kargoya verildi
// orderStatus=3;

//teslim edildi
// orderStatus=4;

using System.ComponentModel;
using System.Net;

Gender gender1 = Gender.Female;
int gender2 = 1;



enum Gender
{
    Female,
    Male
}


enum OrderStatus
{
    Received = 1,
    [Description("Hazırlanıyor")]
    Procesing = 2,
    Shipped = 3,
    Delivered = 4
}
