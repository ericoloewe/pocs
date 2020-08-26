import React, { Component } from 'react'

import Item from './components/Item'
import Scanner from './components/Scanner'
import Cart from './components/Cart'
import CartButton from './components/CartButton'
import Button from './components/Button'
import { fetchSkuDataByEAN } from './services/vtexCatalog'
import {
  addToCart,
  autoAddToCart,
  getOrderForm,
  getSkuPricesFromSimulation,
  updateItems,
} from './fetchers/checkoutFetcher'
import {
  getOrderFormIdFromCookie,
  incrementItemQuantityByEAN,
  incrementItemQuantityById,
  isSkuOnCartByEAN,
  isSkuOnCartById,
} from './utils/helper'

const EMPTY_PRODUCT = {
  ean: null,
  name: null,
  imageURL: null,
  skuId: null,
  skuPrices: {
    listPrice: null,
    price: null,
  },
}

export default class App extends Component {
  constructor(props) {
    super(props)

    this.state = {
      isAutoAddActive: false,
      isCartVisible: false,
      isLoading: true,
      orderForm: {},
      product: EMPTY_PRODUCT,
    }
  }

  componentDidMount() {
    const orderFormId = getOrderFormIdFromCookie()

    getOrderForm(orderFormId)
      .then(this.handleOrderFormResponse)
      .catch(this.handlePromiseError)
  }

  onDetected = product => {
    const {
      isAutoAddActive,
      isCartVisible,
      isLoading,
      orderForm: { items: orderFormItems, orderFormId },
      product: { ean: stateProductEAN },
    } = this.state
    const productEAN = product && product.codeResult && product.codeResult.code

    if (
      !isLoading &&
      !isCartVisible &&
      productEAN &&
      productEAN !== stateProductEAN
    ) {
      if (isAutoAddActive) {
        this.setState({ isLoading: true }, () => {
          orderFormItems && isSkuOnCartByEAN(productEAN, orderFormItems)
            ? updateItems(
                orderFormId,
                incrementItemQuantityByEAN(orderFormItems, productEAN),
              )
                .then(this.handleOrderFormResponse)
                .catch(e => {
                  this.handlePromiseErrorWithEAN(e, productEAN)
                })
            : autoAddToCart(orderFormId, productEAN)
                .then(this.handleOrderFormResponse)
                .catch(e => {
                  this.handlePromiseErrorWithEAN(e, productEAN)
                })
        })
      } else {
        this.setState({ isLoading: true }, () => {
          fetchSkuDataByEAN(productEAN)
            .then(skuData => {
              this.setState({
                product: {
                  ean: productEAN,
                  name: (skuData && skuData.ProductName) || null,
                  imageURL: (skuData && skuData.ImageUrl) || null,
                  skuId: skuData.Id,
                },
              })
              return skuData && skuData.Id
            })
            .then(skuId => {
              getSkuPricesFromSimulation(skuId).then(skuPricesObject => {
                this.setState(prevState => ({
                  isLoading: false,
                  product: {
                    ...prevState.product,
                    skuPrices: {
                      price: (skuPricesObject && skuPricesObject.price) || null,
                      listPrice:
                        (skuPricesObject && skuPricesObject.listPrice) || null,
                    },
                  },
                }))
              })
            })
            .catch(e => {
              this.handlePromiseErrorWithEAN(e, productEAN)
            })
        })
      }
    }
  }

  handleAutoAddToggle = () => {
    this.setState(prevState => ({
      ...prevState,
      isAutoAddActive: !prevState.isAutoAddActive,
    }))
  }

  handleCartVisibilityToggle = () => {
    this.setState(prevState => ({
      ...prevState,
      isCartVisible: !prevState.isCartVisible,
    }))
  }

  handleHideProduct = () => {
    this.setState({ product: EMPTY_PRODUCT })
  }

  handleOrderFormResponse = orderForm => {
    this.setState({ isLoading: false, orderForm })
  }

  handlePromiseError = err => {
    this.setState({ isLoading: false, productEAN }, () => {
      console.log(err)
    })
  }

  handlePromiseErrorWithEAN = (err, productEAN) => {
    this.setState({ isLoading: false, productEAN }, () => {
      console.log(err)
    })
  }

  handleAddToCart = () => {
    const {
      orderForm: { items: orderFormItems, orderFormId },
      product: { skuId },
    } = this.state

    orderFormItems && isSkuOnCartById(skuId, orderFormItems)
      ? updateItems(
          orderFormId,
          incrementItemQuantityById(orderFormItems, skuId),
        )
          .then(this.handleOrderFormResponse)
          .catch(this.handlePromiseError)
      : addToCart(orderFormId, skuId, 1)
          .then(this.handleOrderFormResponse)
          .catch(this.handlePromiseError)

    this.handleHideProduct()
  }

  render() {
    const {
      isAutoAddActive,
      isCartVisible,
      orderForm: { items },
      product: { imageURL: productImageURL, name: productName, skuPrices },
    } = this.state
    const productListPrice = skuPrices && skuPrices.listPrice
    const productPrice = skuPrices && skuPrices.price
    const totalProductQuantity =
      (items && items.reduce((acc, entry) => acc + entry.quantity, 0)) || 0

    return (
      <div style={fitToScreen}>
        <Cart
          isVisible={isCartVisible}
          onBack={this.handleCartVisibilityToggle}
          productsList={items || []}
        />
        <Scanner
          isAutoAddActive={isAutoAddActive}
          onAutoAddToggle={this.handleAutoAddToggle}
          onDetected={this.onDetected}
        />
        <div className="flex-column absolute self-end bottom-0 right-0 w-100">
          <div className="flex justify-end items-end mb5 mr5 tr">
            <CartButton
              isVisible={!isCartVisible}
              onClick={this.handleCartVisibilityToggle}
              quantity={totalProductQuantity}
            />
          </div>
          {productName &&
            productListPrice &&
            productPrice && (
              <div>
                <Item
                  imageURL={productImageURL}
                  listPrice={productListPrice}
                  name={productName}
                  price={productPrice}
                />
                <div className="flex justify-center items-center w-100 ph5 pb7 pt2">
                  <Button
                    text="CANCEL"
                    styleClass="bg-white blue"
                    onClick={this.handleHideProduct}
                  />
                  <Button
                    text="ADD TO CART"
                    styleClass="bg-blue white"
                    onClick={this.handleAddToCart}
                  />
                </div>
              </div>
            )}
        </div>
      </div>
    )
  }
}

const fitToScreen = {
  overflow: 'hidden',
  height: window.innerHeight,
}
