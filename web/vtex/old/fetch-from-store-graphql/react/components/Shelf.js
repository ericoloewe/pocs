import React, {Component} from 'react'
import PropTypes from 'prop-types'
import {FormattedMessage} from 'react-intl'
import {compose, graphql} from 'react-apollo'
import ProductImage from './ProductImage'
import JSONTree from 'react-json-tree'
import productsQuery from './queries/products.graphql'

class Shelf extends Component {
  render() {
    const {data} = this.props
    return (
      <div>
        <JSONTree data={data} />
        {data.loading
          ? <FormattedMessage id="store-graphql.loading" />
          : data.products
            ? (
              <div className="cf pa2">
                {data.products.map(product => (
                  <div key={product.productId} className="fl w-50 w-25-m w-20-l pa2">
                    <a href={product.link} className="db link dim tc">
                      <ProductImage
                        width="250" height="250"
                        url={product.items[0].images[0].imageUrl}
                        alt={product.productName}
                        className="w-100 db outline black-10"/>
                      <dl className="mt2 f6 lh-copy">
                        <dt className="clip">Product Name</dt>
                        <dd className="ml0 black truncate w-100">{product.productName}</dd>
                        <dt className="clip">Price</dt>
                        <dd className="ml0 gray truncate w-100">
                          {product.items[0].sellers[0].commertialOffer.Price}
                        </dd>
                      </dl>
                    </a>
                  </div>
                ))}
              </div>
            )
            : <div>Empty</div>
        }
      </div>
    )
  }
}

Shelf.propTypes = {
  data: PropTypes.object.isRequired,
}

const options = {
  options: ({ query = '', category = '', specificationFilters = '', priceRange = '', collection = '', orderBy = '', from = 0, to = 10, salesChannel = '' }) => ({
    variables: {
      query,
      category,
      specificationFilters: specificationFilters?[specificationFilters]:[],
      priceRange,
      collection,
      orderBy,
      from,
      to,
      salesChannel,
    },
  }),
}

export default compose(
  graphql(productsQuery, options),
)(Shelf)
