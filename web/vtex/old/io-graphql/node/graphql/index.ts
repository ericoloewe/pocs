// NOTE: Any dependencies should be defined at `node/package.json`
import random from 'random-js'

/**
 * NOTE: All resolvers should be included in this exported object, following
 * the usual conventions in GraphQL. Check out the following for more
 * details: https://www.apollographql.com/docs/graphql-tools/resolvers.html.
 **/
export const resolvers = {
  Query: {
    liveViewers: (root, args, context, info) => {
      /**
       * NOTE: The `productId` argument will be available inside `args`,
       * for example:
       * const {productId} = args
       */

      /**
       * NOTE: The `context` parameter has some useful data coming from VTEX IO,
       * for example:
       * const {vtex: {account, workspace}, request, response} = context
       */

      // You can do whatever you need here.
      return random().integer(1000, 10000)
    }
  },
}
