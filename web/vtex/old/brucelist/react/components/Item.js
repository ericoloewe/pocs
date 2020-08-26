import PropTypes from 'prop-types'
import React, { Component } from 'react'

import Svg from './Svg'
import { getFormattedPrice } from '../utils/helper'

import arrowIcon from '../assets/ic_keyboard_arrow_right_48px.svg'

class Item extends Component {
  getNumberCounter(number) {
    return (
      <div className="z-2 absolute tc top-0 left-0 ba b--near-black bg-white fixed-size-unit br-100 h1 w1 f7">
        {number}
      </div>
    )
  }

  render() {
    const {
      imageURL,
      listPrice,
      name,
      price,
      quantity,
      shouldShowQuantity,
    } = this.props

    return (
      <div className="z-2 w-100 ph2 pb2">
        <div className="flex bg-white br2 pa4 shadow-4 justify-between">
          <div className="flex">
            <div className="pa1">
              <div className="relative">
                {shouldShowQuantity && this.getNumberCounter(quantity)}
                {imageURL ? (
                  <img className="ba br2 light-gray ml3 mt2" src={imageURL} />
                ) : (
                  <span className="ba br2 light-gray ml3 mt2">image</span>
                )}
              </div>
            </div>
            <div className="pl4 self-center">
              <p className="ma0 dark-gray">{name}</p>
              <p className="ma0">
                {quantity && `${quantity} x `}
                {listPrice !== price && (
                  <span className="striked">
                    {`R$ ${getFormattedPrice(listPrice)} `}
                  </span>
                )}
                <span className="b">{`R$ ${getFormattedPrice(price)}`}</span>
              </p>
            </div>
          </div>
          <div className="self-center">
            <Svg source={arrowIcon} />
          </div>
        </div>
      </div>
    )
  }
}

Item.propTypes = {
  imageURL: PropTypes.string,
  listPrice: PropTypes.number.isRequired,
  name: PropTypes.string.isRequired,
  price: PropTypes.number.isRequired,
  quantity: PropTypes.number,
  shouldShowQuantity: PropTypes.bool,
}

export default Item
