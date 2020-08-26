import React, {Component} from 'react'
import PropTypes from 'prop-types'
import {ExtensionPoint, Link, Helmet} from 'render'
import {FormattedMessage, FormattedHTMLMessage, injectIntl, intlShape} from 'react-intl'

class GettingStartedIndex extends Component {
  static propTypes = {
    intl: intlShape,
    to: PropTypes.string,
  }

  render () {
    const {to, intl: {formatMessage}} = this.props

    return (
      <article className="bg-serious-black">
        <Helmet title={formatMessage({id: 'getting-started.title'})} />
        <header className="bg-heavy-rebel-pink sans-serif white">
          <div className="mw8 center pa6 pv6-ns ph7-1">
            <h1 className="f2 f1-m f-headline-l lh-title mv0">
              <FormattedMessage id="getting-started.greeting"/>
            </h1>
            <h3 className="f3 fw1 georgia">
              <FormattedMessage id="getting-started.description"/>
            </h3>
            <h4 className="f6 ttu tracked black-80">
              @renderteam
            </h4>
          </div>
        </header>
        {__RUNTIME__.hints && __RUNTIME__.hints.mobile && <FormattedMessage id="getting-started.mobile"/>}
        {!this.props.children && (
          <div className="pa4 ph7-l georgia mw8 center near-white f4">
            <ExtensionPoint id="first-step">
            </ExtensionPoint>
            <ExtensionPoint id="second-step">
            </ExtensionPoint>
            <ExtensionPoint id="configurable-component">
            </ExtensionPoint>
            <ExtensionPoint id="empty">
            </ExtensionPoint>
            <Link to={to} className="f4 fw6 db rebel-pink no-underline underline-hover">
              Link to {to}
            </Link>
          </div>
        )}
        {this.props.children}
      </article>
    )
  }
}

export default injectIntl(GettingStartedIndex)
