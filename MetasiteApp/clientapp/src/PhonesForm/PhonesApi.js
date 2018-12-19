export async function fetchData(dataType, from, to) {
  const response = await fetch(mapToApiUrl(dataType, from, to))
  if (!response.ok) {
      throw Error(response.statusText)
  }

  return await response.json()
}

function mapToApiUrl(dataType, from, to) {
  switch(dataType) {
    case 'total-sms':
      return `api/sms/total?from=${from}&to=${to}`
    case 'total-calls':
      return `api/calls/total?from=${from}&to=${to}`
    case 'top5-phones-with-longest-calls':
      return `api/calls/top5/longest?from=${from}&to=${to}`
    case 'top5-phones-with-most-sms':
      return `api/sms/top5/most?from=${from}&to=${to}`
    default:
      throw new Error(`Unknown dataType: ${dataType}`)
  }
}
