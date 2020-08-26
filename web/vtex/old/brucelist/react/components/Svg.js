import PropTypes from 'prop-types'
import React from 'react'

const Svg = ({ onClick, source, styleClass }) => (
  <img className={styleClass} onClick={onClick} src={source} />
)

Svg.propTypes = {
  onClick: PropTypes.func,
  styleClass: PropTypes.string,
  source: PropTypes.string.isRequired,
}

export default Svg
