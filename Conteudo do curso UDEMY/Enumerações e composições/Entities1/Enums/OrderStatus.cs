/*
    // NOTAS UML
                <<enum>>                                                <<enum>>
             OrderStatus                                               OrderStatus
        -PENDING_PAYMENT:int=0                                  -<<enum constant>>PENDING_PAYMENT:int=0                          
        -PROCESSING:int=1                                       -<<enum constant>>PROCESSING:int=1
        -SHIPPED:int=2                                          -<<enum constant>>SHIPPED:int=2
        -DELIVERED:int=3                                        -<<enum constant>>DELIVERED:int=3
 */
namespace Course.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
