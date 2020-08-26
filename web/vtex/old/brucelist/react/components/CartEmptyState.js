import React from 'react'
import Svg from './Svg'
import emptyCart from '../assets/empty-cart.svg'
import cameraIcon from '../assets/ic_photo_camera_48px.svg'

const CartEmptyState = (props) => (
	<div className="flex absolute flex-column bg-white justify-between items-center h-100 w-100 tr pv6">
		<div className="flex flex-column justify-center items-center mt7">
			<p className="normal ma0 f3 dark-gray">YOUR MARVELOUS CART</p>
			<p className="b ma0 f3 dark-gray">IS EMPTY</p>
		</div>
		<Svg source={emptyCart} styleClass="mt7" />
		<p className="normal dark-gray">GO SCAN SOME STUFF</p>
		<div className="flex bt w-100 light-gray justify-center items-center mt4 pt6" onClick={props.onBack}>
			<Svg
				styleClass="z-3"
				source={cameraIcon}
			/>
		</div>
	</div>
)

export default CartEmptyState