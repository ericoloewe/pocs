import React from 'react'
import PropTypes from 'prop-types'
import {graphql, compose} from 'react-apollo'

import query_user from './user.gql'
import query_list from './list.gql'

function SampleApp({q1, q2}) {
  console.log(q1, q2)
  return (
    <div>
      <h2 className="tc pt4">
        Hey hey {q1.user.first_name} {q1.user.last_name}!
      </h2>
      <p className="pl5 b">Other users:</p>
      <ul className="pl6 i">
        {q2.list &&
          q2.list
            .filter(user => {
              return user.id !== q1.user.id
            })
            .map(user => {
              return (
                <li className="pb1 db" key={user.id}>
                  {user.first_name} {user.last_name}
                </li>
              )
            })}
      </ul>
    </div>
  )
}

SampleApp.propTypes = {
  q1: PropTypes.object,
  q2: PropTypes.object,
}

const queryOptions = {
  name: 'q1',
  options: {
    variables: {
      name: 'abc',
    },
  },
}

export default compose(
  graphql(query_user, queryOptions),
  graphql(query_list, {name: 'q2'}),
)(SampleApp)
