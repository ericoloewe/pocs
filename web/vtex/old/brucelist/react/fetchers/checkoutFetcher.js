import axios from 'axios'

const CHECKOUT_ENDPOINT = '/api/checkout/pub'

export const getOrderForm = async orderFormId => {
  const response = await axios.get(
    `${CHECKOUT_ENDPOINT}/orderForm${orderFormId ? `/${orderFormId}` : ''}`,
  )

  return response.data
}

export const addToCart = async (orderFormId, skuId, quantity) => {
  const response = await axios.post(
    `${CHECKOUT_ENDPOINT}/orderForm/${orderFormId}/items`,
    {
      orderItems: [
        {
          id: skuId,
          seller: '1',
          quantity,
        },
      ],
      expectedOrderFormSections: [
        'items',
        'totalizers',
        'clientProfileData',
        'messages',
        'marketingData',
      ],
    },
  )

  return response.data
}

export const getSkuPricesFromSimulation = async skuId => {
  const response = await axios.post(
    `${CHECKOUT_ENDPOINT}/orderforms/simulation`,
    {
      items: [
        {
          id: skuId,
          seller: '1',
          quantity: 1,
        },
      ],
    },
  )

  const data = response.data &&
    response.data.items &&
    response.data.items.length > 0 && {
      listPrice: response.data.items[0].listPrice,
      price: response.data.items[0].price,
    }

  return data
}

export const autoAddToCart = async (orderFormId, ean) => {
  const response = await axios.post(
    `${CHECKOUT_ENDPOINT}/orderForm/${orderFormId}/items`,
    {
      orderItems: [
        {
          ean,
          seller: '1',
          quantity: 1,
        },
      ],
      expectedOrderFormSections: [
        'items',
        'totalizers',
        'clientProfileData',
        'messages',
        'marketingData',
      ],
    },
  )

  return response && response.data
}

export const updateItems = async (orderFormId, orderItems) => {
  const response = await axios.post(
    `${CHECKOUT_ENDPOINT}/orderForm/${orderFormId}/items/update`,
    {
      orderItems,
      expectedOrderFormSections: [
        'items',
        'totalizers',
        'clientProfileData',
        'messages',
        'marketingData',
      ],
    },
  )

  return response && response.data
}
