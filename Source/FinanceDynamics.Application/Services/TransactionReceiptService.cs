using FinanceDynamics.Application.DTOs;
using FinanceDynamics.Application.Interfaces;
using FinanceDynamics.Domain.Enums;

namespace FinanceDynamics.Application.Services
{
    public class TransactionReceiptService : ITransactionReceiptService
    {
        private ITransactionReceiptRepository _transactionReceiptRepository;

        public TransactionReceiptService(ITransactionReceiptRepository transactionReceiptRepository)
        {
            _transactionReceiptRepository = transactionReceiptRepository;
        }

        public async Task<ReceiptDTO?> GetReceipt(string idTransaction, TransactionType transactionType)
        {
            var transactionReceipt = await _transactionReceiptRepository.GetReceipt(idTransaction, transactionType);

            return transactionReceipt is not null
                ? new ReceiptDTO(
                    transactionReceipt.GetNameFile(), 
                    transactionReceipt.GetExtension(), 
                    GetMIMETypeService.GetMIMEType(transactionReceipt.GetExtension()), 
                    transactionReceipt.GetFile()
                )
                : null;
        }
    }
}