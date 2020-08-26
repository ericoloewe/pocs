import React from 'react'
import PropTypes from 'prop-types'
import {FormattedMessage} from 'react-intl'
import JSONTree from 'react-json-tree'
import {compose, graphql} from 'react-apollo'

import facetsQuery from './queries/facets.graphql'

function FacetsExample({ data: { loading, facets } }) {
  return (
    <div>
      {loading && <FormattedMessage id="store-graphql.loading" />}
      {!loading && <JSONTree data={facets} invertTheme={false} />}
    </div>
  )
}

FacetsExample.propTypes = {
  data: PropTypes.object,
}

const options = {options: ({facets = ''}) => ({ variables: { facets } })}

export default compose(
  graphql(facetsQuery, options),
)(FacetsExample)
