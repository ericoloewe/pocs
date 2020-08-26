import PropTypes from 'prop-types'
import React from 'react'
import Spinner from '@vtex/styleguide/lib/Spinner'

import cartIcon from '../assets/cart-simple.svg'
import Svg from './Svg'

const CartButton = ({ isVisible, onClick, quantity }) =>
  isVisible && (
    <div
      className="flex items-center justify-center br-pill bg-blue w3 h3 shadow-1"
      onClick={onClick}
    >
      {quantity > 0 && (
        <div className="z-3 f6 fw4 h1 w1 absolute tc top-0 right-1 bg-white fixed-size-unit br-100">
          {quantity}
        </div>
      )}
      <Svg source={cartIcon} />
    </div>
  )

CartButton.propTypes = {
  isVisible: PropTypes.bool.isRequired,
  onClick: PropTypes.func.isRequired,
  quantity: PropTypes.number.isRequired,
}

export default CartButton
