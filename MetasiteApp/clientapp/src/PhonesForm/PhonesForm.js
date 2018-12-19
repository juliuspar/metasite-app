import React, { Component } from 'react'
import ResultsPanel from './ResultsPanel.js'
import InputForm from './InputForm.js'

export default class PhonesForm extends Component {
    constructor(props) {
      super(props)
      this.handleSubmit = this.handleSubmit.bind(this)
      this.state = { 
          input: null
      }
    }

    handleSubmit(values) {
        this.setState({input : values.input})
    }

    render() {
        return (
            <div>
                <InputForm onSubmit={this.handleSubmit}/>
                {this.state.input ? <ResultsPanel input={this.state.input} /> : ''}
            </div>
        )
    }
}  