/**
 * Product list page
 */
import "../styles/pages/product-list.scss";
import React from 'react';
import { ProductListContainer } from "../containers";
import { ErrorBoundaryComponent } from "../components";

class ProductPoc extends React.Component {
  render() {
    return (
      <div className="product-poc container">
        <h1>Products poc</h1>
        <ErrorBoundaryComponent>
          <ProductListContainer />
        </ErrorBoundaryComponent>
      </div>
    );
  }
}

export default ProductPoc;
