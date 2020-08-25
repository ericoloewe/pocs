import { AxiosInstance } from "axios";

export class DocumentClient {
  private instance: AxiosInstance;

  constructor(instance: AxiosInstance) {
    this.instance = instance
  }

  async GetById(entity: string, id: string) {
    const res = await this.instance.get(`dataentities/${entity}/documents/${id}?_fields=_all`)

    if (res.status === 200)
      return res.data

    console.log(res)
    return null
  }

  async Search(entity: string, query?: object) {
    const res = await this.instance.get(`dataentities/${entity}/search`, { params: query })

    if (res.status === 200)
      return res.data

    console.log(res)
    return null
  }
}