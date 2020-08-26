import React from 'react'

const Button = (props) => (
	<div className={`br3 w-100 mh4 tc ${props.styleClass}`} onClick={props.onClick}>
		<p>{props.text}</p>
	</div>
)

export default Button