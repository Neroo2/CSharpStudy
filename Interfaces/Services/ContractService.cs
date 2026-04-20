using System;
using Interfaces.Entities;

namespace Interfaces.Services;

public class ContractService
{
    
    private OnlinePaymentService _onlinePaymentService;

    public ContractService(OnlinePaymentService payservice)
    {
        _onlinePaymentService = payservice;
    }


    public void ProcessContract(Contract contract, int months)
    {
        
        double installmentValue = contract.TotalValue/months;


        for (int i = 1; i <= months; i++)
        {
            DateTime date = contract.Date.AddMonths(i);
            double interestValue =  installmentValue+_onlinePaymentService.interest(installmentValue, i);
            double paymentFeeValue =  _onlinePaymentService.paymentFee(interestValue);
            contract.addInstallment(new Installment(date, paymentFeeValue));
        }


    }


}
