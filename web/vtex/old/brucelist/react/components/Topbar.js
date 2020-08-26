import React, { Component } from 'react'
import PropTypes from 'prop-types'

export default class Topbar extends Component {
  render() {
    const { isActive, onAutoAddToggle } = this.props

    return (
      <div className="bg-dark-gray tc" style={{ height: '25px' }}>
        <span className="white mr3 f7">Auto add to cart</span>
        <div className="h2 w2 dib" onClick={() => onAutoAddToggle()}>
          <span
            className={`br-pill v-mid dib pa1 ${
              isActive ? 'bg-green' : 'bg-gray'
            }`}
            style={{ height: '9px', width: '22px' }}
          >
            <span
              className={`br-100 v-mid bg-white db pa1 ${
                isActive ? 'ml4' : ''
              }`}
              style={{ height: '5px', width: '5px' }}
            />
          </span>
        </div>
      </div>
    )
  }
}

Topbar.propTypes = {
  isActive: PropTypes.bool,
  onAutoAddToggle: PropTypes.func,
}
