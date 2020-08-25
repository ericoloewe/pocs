import { AxiosInstance } from "axios";

export class OrdersClient {
  private instance: AxiosInstance;

  constructor(instance: AxiosInstance) {
    this.instance = instance
  }

  async GetOrdersIntervalDates(page: number, dataInicio: Date, dataFim: Date) {
    const res = await this.instance.get('oms/pvt/orders', {
      params: { page: page, f_creationDate: `creationDate:[${dataInicio.toISOString()} TO ${dataFim.toISOString()}]` },
    })

    if (res.status === 200)
      return res.data

    console.log(res)
    return null
  }

  async GetOrdersDetails(order: string) {
    const res = await this.instance.get(`oms/pvt/orders/${order}`)

    if (res.status === 200)
      return res.data

    console.log(res)
    return null
  }
}