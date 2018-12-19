import React, { Component } from 'react'
import { fetchData } from './PhonesApi.js'
import { StyledResultHeaderDiv, StyledResultRowDiv } from './ResultsPanelStyle.js'

export default class ResultsPanel extends Component {
  constructor(props) {
    super(props)
    this.state = { 
      results: null, 
      error: null,
      loading: true
    }
  }

  async componentDidMount() {
    await this.loadPhonesData()
  }

  async componentDidUpdate(prevProps, prevState) {
    if (prevProps.input !== this.props.input) {
      await this.loadPhonesData()
    }
  }

  async loadPhonesData() {
    try
    {
      let data = await fetchData(
        this.props.input.filterType, 
        this.props.input.from,
        this.props.input.to)

      this.setState({ results: data, error: {}, loading: false })
    } 
    catch(err) {
      this.setState({ results: {}, error: err, loading: false })
    }
  }

  render() {
    return (
      <div>
        {this.state.loading ? 
        <p><em>Loading...</em></p> : 
        this.renderResults(this.state.results) }
      </div>
    );
  }

  renderResults(results) {
    if (results.error) {
      return (
      <div>
        {results.error}
      </div> 
      )
    }

    return (
      <div>
        {Object.keys(results).map((k,i) =>
        <div key={i}>
          <StyledResultHeaderDiv>{k}</StyledResultHeaderDiv>
          <StyledResultRowDiv>
            {renderValues(results[k])}
          </StyledResultRowDiv>
        </div>)}
      </div>
    )

    function renderValues(values) {
      if (Array.isArray(values)) {
        return values.map((v,i) => <div key={i}>{v}</div>)
      }
  
      return <div>{values}</div>
    }
  }
}