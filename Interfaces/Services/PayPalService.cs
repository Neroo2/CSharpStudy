using System;

namespace Interfaces.Services;

public class PayPalService : OnlinePaymentService
{
    public double interest(double amount, int months)
    {
        return amount * 0.01 * months;
    }

    public double paymentFee(double amount)
    {
        return amount + (amount * 0.02);
    }
}
