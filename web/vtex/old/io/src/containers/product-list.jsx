/**
 * Product list container
 */
import React from 'react';
import JSONTree from 'react-json-tree'
import { graphql } from 'react-apollo';
import { ProductItemComponent } from "../components";
import { productsQuery } from '../queries';

class ProductListContainer extends React.Component {
  render() {
    return (
      <div className="product-list">
        <JSONTree data={productsQuery} />
        <JSONTree data={this} />
        <div className="row">
          {this.renderProducts()}
        </div>
      </div>
    );
  }

  renderProducts() {
    const { products } = this.props;
    let component = null;

    if (Array.isArray(products)) {
      component = products.map(p => <ProductItemComponent item={p} />);
    }

    return component;
  }
}

const options = {
  options: ({ query = '', category = '', specificationFilters = '', priceRange = '', collection = '', orderBy = '', from = 0, to = 10, salesChannel = '' }) => ({
    variables: {
      query,
      category,
      specificationFilters: specificationFilters ? [specificationFilters] : [],
      priceRange,
      collection,
      orderBy,
      from,
      to,
      salesChannel,
    },
  }),
}

ProductListContainer = graphql(productsQuery, options)(ProductListContainer);

export { ProductListContainer };
