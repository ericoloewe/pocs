import React from 'react'
import PropTypes from 'prop-types'
import {FormattedMessage} from 'react-intl'
import {compose, graphql} from 'react-apollo'
import JSONTree from 'react-json-tree'

import productsQuery from './queries/products.graphql'

function ProductsExample({ data: { loading, products } }) {
  return (
    <div>
      {loading && <FormattedMessage id="store-graphql.loading" />}
      {!loading && <JSONTree data={products} invertTheme={false} />}
    </div>
  )
}

ProductsExample.propTypes = {
  data: PropTypes.object,
}

const options = {
  options: ({ query = '', category = '', specificationFilters = '', priceRange = '', collection = '', orderBy = '', from = 0, to = 10 }) => ({
    variables: {
      query,
      category,
      specificationFilters: specificationFilters?[specificationFilters]:[],
      priceRange,
      collection,
      orderBy,
      from,
      to
    },
  }),
}

export default compose(
  graphql(productsQuery, options),
)(ProductsExample)
