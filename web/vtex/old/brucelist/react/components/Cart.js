import PropTypes from 'prop-types'
import React, { Component } from 'react'

import CartEmptyState from './CartEmptyState'
import Item from './Item'
import Svg from './Svg'

import Button from './Button'
import Transfer from './Transfer'
import emptyCart from '../assets/empty-cart.svg'
import cameraIcon from '../assets/ic_photo_camera_48px.svg'

import {
  // generateOnlineCheckoutURL,
  getFormattedPrice,
  getOrderFormIdFromCookie,
} from '../utils/helper'

export default class Cart extends Component {
  constructor(props) {
    super(props)

    this.state = {
      shouldShowTransfer: false,
    }
  }

  handleRedirectToOnlineCheckout = () => {
    // se mudar a rota da page temq mudar aqui esse split
    location.href = location.href.split('brucelist')[0] + 'checkout'
  }

  handleShowTransferToggle = () => {
    this.setState(prevState => ({
      ...prevState,
      shouldShowTransfer: !prevState.shouldShowTransfer,
    }))
  }

  render() {
    const { isVisible, onBack, productsList } = this.props
    const { shouldShowTransfer } = this.state

    if (!isVisible) {
      return null
    }

    if (shouldShowTransfer) {
      const orderFormId = getOrderFormIdFromCookie()

      return (
        <Transfer
          value={orderFormId}
          onHide={this.handleShowTransferToggle}
        />
      )
    }

    if (productsList.length === 0) {
      return <CartEmptyState onBack={onBack} />
    }

    return (
      <div className="flex absolute flex-column bg-white justify-between items-center h-100 w-100 tr pv6 z-2">
        <p className="normal ma0 f3 dark-gray">YOUR MARVELOUS CART</p>
        <div className="dib w-100 ph2">
          {productsList.map((entry, index) => (
            <Item
              key={index}
              imageURL={entry.imageUrl}
              listPrice={entry.listPrice}
              name={entry.name}
              price={entry.price}
              quantity={entry.quantity}
              shouldShowQuantity
            />
          ))}
        </div>
        <div className="flex bt w100 light-gray justify-center items-center mt4 pt6">
          <Svg onClick={onBack} source={cameraIcon} />
          <Button
            text="CART TRANSFER"
            styleClass="bg-white blue ba"
            onClick={this.handleShowTransferToggle}
          />
          <Button
            text="ONLINE CHECKOUT"
            styleClass="bg-blue white"
            onClick={this.handleRedirectToOnlineCheckout}
          />
        </div>
      </div>
    )
  }
}

Cart.propTypes = {
  isVisible: PropTypes.bool.isRequired,
  onBack: PropTypes.func.isRequired,
  productsList: PropTypes.arrayOf(PropTypes.object).isRequired,
}
