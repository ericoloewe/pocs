import React, { Component } from 'react'
import PropTypes from 'prop-types'
import Quagga from 'quagga'
import Topbar from './Topbar'

export default class Scanner extends Component {
  componentDidMount() {
    Quagga.init(
      {
        inputStream: {
          type: 'LiveStream',
          constraints: {
            width: window.innerWidth,
            height: window.innerHeight,
            facingMode: 'environment', // or user
          },
        },
        locator: {
          patchSize: 'medium',
          halfSample: true,
        },
        numOfWorkers: 2,
        decoder: {
          readers: ['code_128_reader'],
        },
        locate: true,
      },
      function(err) {
        if (err) {
          console.log(err)
        }
        Quagga.start()
      },
    )
    Quagga.onDetected(this._onDetected)
    window.scanneiaBaguera = () => this._onDetected({
      codeResult: {
        code: '85014326001'
      }
    })
    if (window) window.document.getElementsByTagName('video')[0].height = window.innerHeight
  }

  componentWillUnmount() {
    Quagga.offDetected(this._onDetected)
  }

  _onDetected = result => {
    this.props.onDetected(result)
  }

  render() {
    const { isAutoAddActive, onAutoAddToggle } = this.props

    return (
      <div className="z-1">
        <Topbar isActive={isAutoAddActive} onAutoAddToggle={onAutoAddToggle} />
        <div id="interactive" className="viewport" style={fitToScreen} />
      </div>
    )
  }
}

const fitToScreen = {
  overflow: 'hidden',
  height: window.innerHeight,
}

Scanner.propTypes = {
  isAutoAddActive: PropTypes.bool.isRequired,
  onDetected: PropTypes.func.isRequired,
  onAutoAddToggle: PropTypes.func.isRequired,
}
