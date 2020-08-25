import axios from 'axios'

/**
 *  Simple in-memory database
 */
const product = {
  length: 420,
  name: 'My awesome product',
  width: 210,
}

/**
 * You shoud write your GraphQL resolvers in here.
 * Resolvers are just usual node functions, so here you can make
 * API calls, connect to the database and transform the data in
 * any way you wish. You can learn more about resolvers and its arguments
 * here: https://www.apollographql.com/docs/graphql-tools/resolvers.html
 */
export const resolvers = {
  Mutation: {
    changeProductName: (_, args, ctx) => {
      console.log('[changeProductName] Received vtex context:', ctx.vtex)
      console.log('[changeProductName] Received arguments:', args)
      product.name = args.targetName
      return product
    }
  },
  Query: {
    myProduct: (_, args, ctx) => {
      console.log('[myProduct] Received vtex context:', ctx.vtex)
      console.log('[myProduct] Received arguments:', args)
      return product
    },
    status: async (_, args, ctx) => {
      console.log('[status] Received vtex context:', ctx.vtex)
      console.log('[status] Received arguments:', args)

      const http = axios.create({
        headers: {
          'Proxy-Authorization': ctx.vtex.authToken,
        }
      })

      try {
        const {data, status, headers} = await http.get(`https://httpstat.us/${args.status}`)
        console.log(`Got response status=${status} data="${data}" headers=${JSON.stringify(headers)}`)
        ctx.set('cache-control', 'no-cache')
        return status
      } catch (e) {
        console.error(e)
        throw e
      }
    }
  }
}
