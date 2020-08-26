import cookie from 'react-cookie'

export function getOrderFormIdFromCookie() {
  const checkoutCookieValue = cookie.load('checkout.vtex.com')
  let orderFormId = null

  if (checkoutCookieValue) {
    const parsedValue = checkoutCookieValue.split('=')

    if (parsedValue[0] === '__ofid' && parsedValue.length === 2) {
      orderFormId = parsedValue[1]
    }
  }

  return orderFormId
}

export const incrementItemQuantityByEAN = (orderFormItems, ean) =>
  orderFormItems.map((item, index) => ({
    id: item.id,
    index: index,
    seller: item.seller,
    quantity: item.quantity + (item.ean === ean ? 1 : 0),
  }))

export const incrementItemQuantityById = (orderFormItems, id) =>
  orderFormItems.map((item, index) => ({
    id: item.id,
    index: index,
    seller: item.seller,
    quantity: item.quantity + (item.id === id.toString() ? 1 : 0),
  }))

export function updateItemQuantity(orderFormItems, ean, newQuantity) {
  return orderFormItems.map(item => {
    if (item.ean === ean) {
      return {
        ...item,
        quantity: newQuantity,
      }
    } else {
      return item
    }
  })
}

export const isSkuOnCartByEAN = (ean, orderItems) =>
  orderItems.some(entry => entry.ean === ean)

export const isSkuOnCartById = (id, orderItems) =>
  orderItems.some(entry => entry.id === id.toString())

export const getFormattedPrice = price =>
  (price / 100)
    .toFixed(2)
    .toString()
    .replace('.', ',')

export const generateOnlineCheckoutURL = orderItems => {
  const CHECKOUT_BASE_URL =
    'https://vtexinstoredev.vtexcommercestable.com.br/checkout/cart/add'

  return orderItems.reduce(
    (acc, entry, index) =>
      acc +
      (index > 0 ? '&' : '?') +
      `sku=${entry.id}&qty=${entry.quantity}&seller=${entry.seller}&sc=1`,
    CHECKOUT_BASE_URL,
  )
}
