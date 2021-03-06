using VND.CoolStore.Services.Cart.Infrastructure.Gateways;
using VND.CoolStore.Services.Cart.Infrastructure.Services;

namespace VND.CoolStore.Services.Cart.Domain
{
  public class TenPercentTaxCalculator : PriceCalculatorContext
  {
    public TenPercentTaxCalculator(IPromoGateway promoGateway, IShippingGateway shippingGateway)
      : base(promoGateway, shippingGateway)
    {
    }

    protected override double AddTaxCost(double total)
    {
      return (total * 10 / 100) + total;
    }
  }
}
