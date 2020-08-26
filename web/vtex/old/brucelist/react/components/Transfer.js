import QRCode from 'qrcode.react'
import Button from './Button'

const Transfer = (props) => (
	<div className="flex absolute flex-column bg-white justify-between items-center h-100 w-100 tr pv6 z-2">
		<h2 className="f3 dark-gray">
      <span className="normal">CART </span>
      <span className="b">TRANSFER</span>
    </h2>
		<QRCode value={props.value} />
		<div className="flex bt w-100 light-gray justify-center items-center mt4 pt6" onClick={props.onBack}>
			<Button
				text="BACK TO CART"
				styleClass="ba blue bg-white"
        onClick={props.onHide}
			/>
		</div>
	</div>
)

export default Transfer
