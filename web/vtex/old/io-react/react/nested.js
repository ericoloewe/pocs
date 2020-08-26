import React from 'react'
import {Link} from 'render'

const Nested = ({params, to = '', children}) =>
  <div className="pa4 ph7 pt0 georgia mw8 center near-white f4">
    <h1>> Nested Route</h1>
    <Link to={to} className="f4 fw6 db rebel-pink no-underline underline-hover">
      Link to {to}
    </Link>
    <p>
      Props:
    </p>
    <p>
      {JSON.stringify({params, to})}
    </p>
    {children}
  </div>

Nested.schema = {
  title: 'Nested',
  description: 'A nested component with a link',
  type: 'object',
  properties: {
    to: {
      type: 'string',
      title: 'Link to',
    },
  },
}

export default Nested
