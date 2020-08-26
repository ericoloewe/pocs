import React, {Component} from 'react'

// GraphQL query wrapper for React
import {graphql} from 'react-apollo'

// You can import any react component you wish
import {Product} from './nested_components/product'

// GraphQL Query
import listProductsQuery from './graphql/listProducts.graphql'

// Default maxItems to show
const MAX_ITEMS = 10

// This is just an usual React component
class ListProducts extends Component {
  render () {
    const {
      maxItems, // This comes from the schema
      data: {   // This comes from the GraphQL Query
        loading,
        products
      }
    } = this.props

    return (
      <div>
      <div className="mh5-ns f4">{products && products.slice(0, maxItems).map(product => (<Product key={product.productId} product={product}/>))}</div>
      </div>
    )
  }
}

// Defining propTypes correctly is very important for react+graphql integration
ListProducts.defaultProps = {
  maxItems: MAX_ITEMS
}

ListProducts.propTypes = {
  maxItems: PropTypes.number,
}

// JSON Schema with in-app settings.
// You can play around with this config at the `edit` button in the lower right corner
ListProducts.getSchema = (props) => {
  return {
    title: 'ListProducts',
    description: 'A simple shelf',
    type: 'object',
    properties: {
      maxItems: {
        title: 'Max Items',
        type: 'number',
        default: ListProducts.defaultProps.maxItems,
      },
    },
  }
}

// Exports the wrapped Component with the GraphQL Query
export default graphql(listProductsQuery, {
  // We need to initialize the query variables
  // since it will be running before rendering the component
  options: ({
    maxItems = ListProducts.defaultProps.maxItems,
  }) => ({
    variables: {
      from: 0,
      to: maxItems-1
    }
  })
})(ListProducts)
