import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import Appbar from './Appbar/Appbar'

export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>
        <Appbar />
        <Container>
          {this.props.children}
        </Container>
      </div>
    );
  }
}
