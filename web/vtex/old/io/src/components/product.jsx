/**
 * Product list container
 */
import React from 'react';

export class ProductItemComponent extends React.Component {
  render() {
    const { item: { name, img } } = this.props;
    return (
      <div className="product-item col-sm">
        <h3>{name}</h3>
        <img src={img} alt={name} />
      </div>
    );
  }
}
