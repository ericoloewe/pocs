import AWS from 'aws-sdk';
import dotenv from 'dotenv'
import { VtexApiClient } from './vtex/api-client';

dotenv.config()

const vtexApiClient = new VtexApiClient({ 'x-vtex-api-appKey': process.env.VTEX_APIKEY, 'x-vtex-api-appToken': process.env.VTEX_APPTOKEN })

AWS.config.update({
  region: "us-east-2",
  credentials: new AWS.CognitoIdentityCredentials({
    IdentityPoolId: 'us-east-2:7ab36441-5388-4086-b98c-738210a489a6',
  }),
});

const docClient = new AWS.DynamoDB.DocumentClient();

export async function handler(event: any) {
  const startTime = new Date()
  const response = {
    statusCode: 200,
    body: JSON.stringify('Hello from Lambda!'),
  };

  const client = await vtexApiClient.getMasterDataClient().Documents.Search('CL')

  const promises = await Promise.all(client.map((customer: object) => {
    return new Promise((resolve, reject) => {
      const params = {
        TableName: "Customers",
        Item: customer
      };

      docClient.put(params, (err, data) => {
        if (err) {
          reject(err);
        } else {
          resolve(data);
        }
      });
    });
  }));

  response.body = JSON.stringify(promises)

  const endTime = new Date()

  console.log('event', event)
  console.log('Start Time: ', startTime.toISOString())
  console.log('End Time: ', endTime.toISOString())
  console.log('Time spent: ', `${(endTime.getTime() - startTime.getTime()) / 1000}s`)

  return response;
}

// handler(null)