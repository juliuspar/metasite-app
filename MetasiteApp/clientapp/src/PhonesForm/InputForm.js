import React, { Component } from 'react'
import { Form, Field } from 'react-final-form'
import PropTypes from 'prop-types';
import InputFormStyle from "./InputFormStyle";

export default class InputForm extends Component {
  constructor(props) {
    super(props)
    this.handleSubmit = this.handleSubmit.bind(this)
  }

  handleSubmit(values) {
    this.props.onSubmit({ input: values })
  }

  render() {
    return (
      <InputFormStyle>
        <Form
          onSubmit={this.handleSubmit}
          initialValues={{ filterType: 'total-sms', from: '', to: '' }}
          render={({ handleSubmit, form, submitting, pristine, values }) => (
            <form onSubmit={handleSubmit}>
              <div>
                <label>From</label>
                <Field
                  name="from"
                  component="input"
                  type="date"
                  placeholder="from"
                />
              </div>
              <div>
                <label>To</label>
                <Field name="to" component="input" type="date" placeholder="to" />
              </div>
              <div>
                <label>Filter type</label>
                <Field name="filterType" component="select">
                  <option value="total-sms">
                    Total sms</option>
                  <option value="total-calls">
                    Total calls
                  </option>
                  <option value="top5-phones-with-longest-calls">
                    Top5 phones with longest calls
                  </option>
                  <option value="top5-phones-with-most-sms">
                    Top5 phones with most sms
                  </option>
                </Field>
              </div>
              <div className="buttons">
                <button type="submit" disabled={submitting}>
                  Filter
                </button>
              </div>
            </form>
          )}/>
    </InputFormStyle>
    )
  }
}

InputForm.propTypes = {
  onSubmit: PropTypes.func.isRequired
}