import axios from 'axios';
import { OrdersClient } from './oms/orders';
import { DocumentClient } from './master-data/documents';
import axiosRetry from 'axios-retry';

export class VtexApiClient {
  private oms: { Orders: OrdersClient };
  private masterData: { Documents: DocumentClient };

  constructor(options: string | object) {
    const instance = axios.create({
      baseURL: 'http://ecoke.vtexcommercestable.com.br/api',
      timeout: 120000,
      headers: options
    })

    axiosRetry(instance, {
      retries: 10, retryDelay: (retryCount) => {
        return retryCount * 2000
      }
    })

    this.oms = {
      Orders: new OrdersClient(instance)
    }

    this.masterData = {
      Documents: new DocumentClient(instance)
    }
  }

  getOmsClient() {
    return this.oms
  }

  getMasterDataClient() {
    return this.masterData
  }
}