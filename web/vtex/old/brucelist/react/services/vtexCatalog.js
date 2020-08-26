import axios from 'axios'

export const fetchSkuDataByEAN = async ean => {
  const response = await axios.get(
    `/api/catalog_system/pvt/sku/stockkeepingunitbyean/${ean}`,
    {
      contentType: 'application/json',
    },
  )

  return response.data
}
