import * as cookies from 'cookie'

const DEFAULT_PAGE_SIZE = 15

export const headers = {
  json: {
    accept: 'application/json',
    'content-type': 'application/json',
  },
  profile: {
    accept: 'application/vnd.vtex.ds.v10+json',
    'content-type': 'application/json',
  },
}

export const withAuthToken = (currentHeaders = {}) => (ioContext, cookie = null) => {
  const ans: any = { ...currentHeaders }
  if (cookie) {
    const parsedCookie = cookies.parse(cookie)
    if (parsedCookie.VtexIdclientAutCookie) {
      ans.VtexIdclientAutCookie = parsedCookie.VtexIdclientAutCookie
    }
  }
  return {
    ...ans,
    Authorization: `${ioContext.authToken}`,
    'Proxy-Authorization': `${ioContext.authToken}`
  }
}

export const withAuthAsVTEXID = (currentHeaders = {}) => (ioContext) => {
  return {
    ...currentHeaders,
    'Proxy-Authorization': ioContext.authToken,
    VtexIdclientAutCookie: ioContext.authToken,
  }
}

export const withMDPagination = (currentHeaders = {}) => (ioContext, cookie = null) => (page = 1, pageSize = DEFAULT_PAGE_SIZE) => {
  if (page < 1) {
    throw new Error('Smallest page value is 1')
  }
  const startIndex = (page - 1) * pageSize
  const endIndex = startIndex + pageSize
  return {
    ...(withAuthToken(currentHeaders)(ioContext, cookie)),
    'REST-Range': `resources=${startIndex}-${endIndex}`
  }
}
