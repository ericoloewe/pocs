/**
 * Utils > PaymentMode
 */

const ROOT_URL = '';
const CHECKOUT_SINGLE_URL = `${ROOT_URL}/checkout/single`;
const CHECKOUT_SUMMARY_URL = `${CHECKOUT_SINGLE_URL}/summary`;

export class PaymentModeUtil {
  static getEndpointByPaymentMode(paymentData, paymentModeCode) {
    let endpoint = null;

    switch (paymentModeCode) {
      case 'CreditCard':
        endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-CC`;
        if (paymentData.paymentId) endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-SCC`;
        break;

      case 'Boleto':
        endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-BO`;
        break;

      case 'TwoCreditCard':
        endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-2CC`;
        break;

      case 'BalanceAccount':
        endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-BA`;
        break;

      case 'Mixed':
        endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-CCBA`;
        if (paymentData.paymentId) endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-SCCBA`;
        break;

      case 'Mixed_BO_BA':
        endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-BOBA`;
        break;

      case 'CallCenterReserve':
        endpoint = `${CHECKOUT_SINGLE_URL}/placeOrder-CallCenterReserve`;
        break;
    }

    return endpoint;
  }

  static getPaymentMethodByPaymentMode(paymentModeCode) {
    let paymentMethod = {};

    switch (paymentModeCode) {
      case 'TwoCreditCard':
        paymentMethod = Object.assign(paymentMethod, {
          method: 'CreditCardMethod',
          numberOfCardsToShow: 2
        });
        break;
      case 'CreditCard':
        paymentMethod.method = 'CreditCardMethod';
        break;
      case 'Boleto':
        paymentMethod.method = 'BoletoMethod';
        break;
      case 'BalanceAccount':
        paymentMethod.method = 'CreditMethod';
        break;
      case 'Mixed':
        paymentMethod.method = 'CreditAndCreditCardMethod';
        break;
      case 'Mixed_BO_BA':
        paymentMethod.method = 'CreditAndBoletoMethod';
        break;
      case 'CallCenterReserve':
        paymentMethod.method = 'CallCenterReserveMethod';
        break;
      default:
        paymentMethod = null
    }

    return paymentMethod;
  }
}
